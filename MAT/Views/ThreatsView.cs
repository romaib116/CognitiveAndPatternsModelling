using CognitiveMaps.MAT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CognitiveMaps.Views
{
    public partial class ThreatsView : Form
    {
        private List<CveEntity> cveList;

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
            get { return _presenter ??= new ThreatsPresenter<ThreatsView>(); }
        }

        public ThreatsView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка получения JSON CVE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCVEButton_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    cveList = Presenter.GetCveList(filePath);
                    listBox1.DataSource = cveList;
                    listBox1.DisplayMember = "Id";
                    textBox1.Text = filePath;
                }
                else
                {
                    MessageBox.Show("Вы не добавили файл");
                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label1.Text = string.Format("CWE: {0};\nОписание: {1};\nURL: {2}\nCVSS:\nАтаке подвержена: {3}\nBase Score: {4}", 
                cveList[listBox1.SelectedIndex].CWE, 
                cveList[listBox1.SelectedIndex].Decription,
                cveList[listBox1.SelectedIndex].Url,
                cveList[listBox1.SelectedIndex].AttackVector,
                cveList[listBox1.SelectedIndex].BaseScore
                );

        }
    }

}
