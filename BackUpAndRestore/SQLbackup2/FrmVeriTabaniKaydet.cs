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
    public partial class FrmVeriTabaniKaydet : Form
    {
        public string DosyaYolu { get; set; }
        public FrmVeriTabaniKaydet()
        {
            InitializeComponent();
        }

        private void VeriTabaniKaydetForm_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\VeriTabani.txt"; ;
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

                MessageBox.Show("Veri Tabanı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void VeriTabaniTemizleBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);
        }

        private void VeriTabaniVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
