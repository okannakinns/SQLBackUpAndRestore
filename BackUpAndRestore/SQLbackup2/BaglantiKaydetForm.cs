using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SQLbackup2
{
    public partial class BaglantiKaydetForm : Form
    {
        public string DosyaYolu { get; set; }
        public BaglantiKaydetForm()
        {
            InitializeComponent();
        }

        private void BaglantiKaydetBtn_Click(object sender, EventArgs e)
        {

            File.WriteAllText(DosyaYolu, string.Empty);
            try
            {
                using (StreamWriter sw = File.AppendText(DosyaYolu))
                {
                    sw.WriteLine(TxtIpBaglantiKaydet.Text);
                    sw.WriteLine(TxtUsernameBaglantiKaydet.Text);
                    sw.WriteLine(TxtSifreBaglantiKaydet.Text);
                }

                MessageBox.Show("Veriler başarıyla dosyaya eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler dosyaya eklenirken bir hata oluştu: " + ex.Message);
            }


        }

        private void BaglantiTemizleBtn_Click(object sender, EventArgs e)
        {


            TxtIpBaglantiKaydet.Text = string.Empty;
            TxtUsernameBaglantiKaydet.Text= string.Empty;
            TxtSifreBaglantiKaydet.Text=string.Empty;

        }

        private void BaglantiVazgecBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaglantiKaydetForm_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Baglanti.txt"; ;
        }
    }
}