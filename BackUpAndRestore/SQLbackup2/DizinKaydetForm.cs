using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLbackup2
{
    public partial class DizinKaydetForm : Form
    {
        public string DosyaYolu { get; set; }
        public DizinKaydetForm()
        {

            InitializeComponent();
        }

        private void dizinGozatBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.ReadOnly = true;
                string klasorYolu = folderBrowserDialog.SelectedPath;
                
                txtPath.Text = klasorYolu;

            }
        }

        private void dizinKaydetBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);

            try
            {
                using (StreamWriter sw = File.AppendText(DosyaYolu))
                {
                    sw.WriteLine(txtPath.Text);
                    
                }

                MessageBox.Show("Dosya yolu eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya yolu eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void dizinTemizleBtn_Click(object sender, EventArgs e)
        {
            
          
                txtPath.Text = string.Empty;
           
        }

        private void dizinVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DizinKaydetForm_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Dizin.txt"; ;
        }
    }
}
