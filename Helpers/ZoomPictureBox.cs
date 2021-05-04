﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognitiveMaps.Helpers
{
    public class ZoomPictureBox : UserControl
    {
        Bitmap image;
        PointF visibleCenter;
        float zoom = 1f;
        MouseState mouseState;
        Point startDragged;
        PointF startDraggedVisibleCenter;
        int sourceImageWidth;
        int sourceImageHeight;

        public event EventHandler VisibleCenterChanged;

        [DefaultValue(0.1f)]
        public float ZoomDelta { get; set; }
        [DefaultValue(true)]
        public bool AllowUserDrag { get; set; }
        [DefaultValue(true)]
        public bool AllowUserZoom { get; set; }

        public InterpolationMode InterpolationMode { get; set; }
        public InterpolationMode InterpolationModeZoomOut { get; set; }
        public PixelOffsetMode PixelOffsetMode { get; set; }

        public ZoomPictureBox()
        {
            //drawing optimization
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            //default settings
            ZoomDelta = 0.1f;
            AllowUserDrag = true;
            AllowUserZoom = true;
            InterpolationMode = InterpolationMode.Bicubic;
            InterpolationModeZoomOut = InterpolationMode.Bilinear;
            PixelOffsetMode = PixelOffsetMode.HighQuality;
        }

        [DefaultValue(null)]
        public Bitmap Image
        {
            get { return image; }
            set
            {
                image = value;

                if (value == null)
                {
                    sourceImageWidth = 0;
                    sourceImageHeight = 0;
                    VisibleCenter = new PointF(0, 0);
                }
                else
                {
                    sourceImageWidth = value.Width;
                    sourceImageHeight = value.Height;
                    VisibleCenter = new PointF(sourceImageWidth / 2f, sourceImageHeight / 2f);
                }

                Invalidate();
            }
        }

        public void UpdateImage(Bitmap image)
        {
            this.image = image;

            if (image != null)
            {
                sourceImageWidth = image.Width;
                sourceImageHeight = image.Height;
            }

            Invalidate();
        }

        [DefaultValue(1f)]
        public float Zoom
        {
            get
            {
                return zoom;
            }

            set
            {
                if (Math.Abs(value) <= float.Epsilon)
                    throw new Exception("Zoom must be more then 0");
                zoom = value;
                Invalidate();
            }
        }

        public PointF VisibleCenter
        {
            get
            {
                return visibleCenter;
            }

            set
            {
                visibleCenter = value;
                OnVisibleCenterChanged();
            }
        }

        public virtual void OnVisibleCenterChanged()
        {
            if (VisibleCenterChanged != null)
                VisibleCenterChanged(this, EventArgs.Empty);

            Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (!AllowUserZoom)
                return;

            if (e.Delta > 0)
                IncreazeZoom();

            if (e.Delta < 0)
                DecreaseZoom();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (AllowUserDrag)
                if (e.Button == MouseButtons.Left)
                {
                    Cursor = Cursors.SizeAll;
                    mouseState = MouseState.Drag;
                }

            startDragged = e.Location;
            startDraggedVisibleCenter = VisibleCenter;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Cursor = Cursors.Default;
            mouseState = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (mouseState == MouseState.Drag)
            {
                var dx = e.Location.X - startDragged.X;
                var dy = e.Location.Y - startDragged.Y;
                VisibleCenter = new PointF(startDraggedVisibleCenter.X - dx / zoom, startDraggedVisibleCenter.Y - dy / zoom);
            }
        }

        public void DecreaseZoom()
        {
            Zoom = (float)Math.Exp(Math.Log(zoom) - ZoomDelta);
        }

        public void IncreazeZoom()
        {
            Zoom = (float)Math.Exp(Math.Log(zoom) + ZoomDelta);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (image == null)
                return;

            e.Graphics.ResetTransform();
            e.Graphics.InterpolationMode = Zoom < 1f ? InterpolationModeZoomOut : InterpolationMode;
            e.Graphics.PixelOffsetMode = PixelOffsetMode;

            if (mouseState == MouseState.Drag)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            }

            var p = ImagePointToClient(Point.Empty);
            e.Graphics.DrawImage(image, p.X, p.Y, image.Width * Zoom, image.Height * Zoom);

            base.OnPaint(e);
        }

        public Point ClientToImagePoint(Point point)
        {
            return Point.Round(ClientToImagePoint((PointF)point));
        }

        public Point ImagePointToClient(Point point)
        {
            return Point.Round(ImagePointToClient((PointF)point));
        }

        public PointF ClientToImagePoint(PointF point)
        {
            var dx = (point.X - ClientSize.Width / 2f) / Zoom + visibleCenter.X;
            var dy = (point.Y - ClientSize.Height / 2f) / Zoom + visibleCenter.Y;
            return new PointF(dx, dy);
        }

        public PointF ImagePointToClient(PointF point)
        {
            var dx = (point.X - visibleCenter.X) * Zoom +0/ 2f;
            var dy = (point.Y - visibleCenter.Y) * Zoom + 0 / 2f;
            return new PointF(dx, dy);
        }

        public Image GetScreenshot()
        {
            Image img = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (var gr = Graphics.FromImage(img))
                OnPaint(new PaintEventArgs(gr, ClientRectangle));
            return img;
        }

        enum MouseState
        {
            None, Drag
        }
    }
}
