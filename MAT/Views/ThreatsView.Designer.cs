
namespace CognitiveMaps.Views
{
    partial class ThreatsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetThreatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 21);
            this.textBox1.TabIndex = 0;
            // 
            // GetThreatsButton
            // 
            this.GetThreatsButton.Location = new System.Drawing.Point(422, 41);
            this.GetThreatsButton.Name = "GetThreatsButton";
            this.GetThreatsButton.Size = new System.Drawing.Size(75, 23);
            this.GetThreatsButton.TabIndex = 1;
            this.GetThreatsButton.Text = "button1";
            this.GetThreatsButton.UseVisualStyleBackColor = true;
            this.GetThreatsButton.Click += new System.EventHandler(this.GetThreatsButton_Click);
            // 
            // ThreatsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetThreatsButton);
            this.Controls.Add(this.textBox1);
            this.Name = "ThreatsView";
            this.Text = "ThreatsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetThreatsButton;
    }
}