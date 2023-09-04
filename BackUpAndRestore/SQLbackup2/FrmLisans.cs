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
    public partial class FrmLisans : Form
    {
        public string DosyaYolu { get; set; }
        public FrmLisans()
        {
            InitializeComponent();
        }

        private void LisansKaydetBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);

            try
            {

                using (StreamWriter sw = File.AppendText(DosyaYolu))
                {
                    sw.WriteLine(txtLisansAnahtari.Text);

                }

                MessageBox.Show("Lisans Anahtarı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lisans Anahtarı eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void FrmLisans_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Lisans.txt"; ;
        }

        private void LisansTemizleBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);
        }

        private void LisansVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
