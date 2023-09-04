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
    public partial class FrmZamaniKaydet : Form
    {
        public string DosyaYolu { get; set; }
        public FrmZamaniKaydet()
        {
            InitializeComponent();
        }

        private void ZamanKaydetBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);

            try
            {
                int deger = Convert.ToInt32(ZamanNumericUD.Value);
                Int64 milisaniye = 0;
                if (deger > 0)
                {
                   if(cmbZamanlar.Text=="Saat")
                    {
                        milisaniye = deger * 60 * 60 * 1000;
                    }
                    if (cmbZamanlar.Text == "Dakika")
                    {
                        milisaniye = deger * 60 * 1000;
                    }
                    if (cmbZamanlar.Text == "Gün")
                    {
                       if(deger>21)
                        {
                            milisaniye = 21 * 24 * 60 * 60 * 1000;
                        }
                       if(deger<=21)
                        {
                            milisaniye = deger * 24 * 60 * 60 * 1000;
                        }
                       
                    }
                    if (cmbZamanlar.Text == "Hafta")
                    {
                        if(deger<=3)
                        {
                            milisaniye = deger * (604800000);
                        }
                        if (deger > 3)
                        {
                            milisaniye = 3 * (604800000);
                        }

                    }
               
                    using (StreamWriter sw = new StreamWriter(DosyaYolu, false))
                    {
                        sw.WriteLine(milisaniye.ToString());
                        sw.Close();
                    }

                    MessageBox.Show("Zaman kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zaman kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }


        

        private void ZamaniKaydetForm_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Zaman.txt";
            List<string> Zamanlistesi = new List<string>();
            Zamanlistesi.Add("Hafta");
            Zamanlistesi.Add("Gün");
            Zamanlistesi.Add("Saat");
            Zamanlistesi.Add("Dakika");
            cmbZamanlar.DataSource = Zamanlistesi;

        }

        private void ZamanTemizleBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DosyaYolu, string.Empty);
        }

        private void ZamanVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
