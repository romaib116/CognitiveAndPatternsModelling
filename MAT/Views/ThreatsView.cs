using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace CognitiveMaps.Views
{
    public partial class ThreatsView : Form
    {
        private ThreatsPresenter<ThreatsView> _presenter;
        /// <summary>
        /// Презентер
        /// </summary>
        public ThreatsPresenter<ThreatsView> Presenter
        {
            set
            {
                _presenter = value;
                _presenter.View = this;
            }
            get { return _presenter; }
        }

        public ThreatsView()
        {
            InitializeComponent();
        }

        private void GetThreatsButton_Click(object sender, System.EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();
                    //
                }
                textBox1.Text = filePath;
            }

        }
    }

}
