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

    public partial class FrmTekrarKaydet : Form
    {
        public string DosyaYolu { get; set; }
        public FrmTekrarKaydet()
        {
            InitializeComponent();
        }

        private void TekrarVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TekrarTemizleBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);
        }

        private void TekrarKaydetForm_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Tekrar.txt"; ;
        }

        private void TekrarKaydetBtn_Click(object sender, EventArgs e)
        {

            File.WriteAllText(DosyaYolu, string.Empty);

            try
            {
                int deger = (int)TekrarNumericUD.Value;
                using (StreamWriter sw = new StreamWriter(DosyaYolu, false))
                {
                    sw.WriteLine(deger.ToString());
                }

                MessageBox.Show("Tekrar Sayısı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tekrar Sayısı kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
