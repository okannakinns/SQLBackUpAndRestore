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

namespace SQLbackup2
{
    public partial class FrmMailKaydet : Form
    {
        public string DosyaYolu { get; set; }
        public FrmMailKaydet()
        {
            InitializeComponent();
        }

        private void FrmMailKaydet_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Mail.txt";
        }

        private void VeriTabaniKaydetBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);

            try
            {

                using (StreamWriter sw = File.AppendText(DosyaYolu))
                {
                    sw.WriteLine(txtDatabase.Text);

                }

                MessageBox.Show("Mail eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void VeriTabaniTemizleBtn_Click(object sender, EventArgs e)
        {
            txtDatabase.Text=string.Empty;
        }

        private void VeriTabaniVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
