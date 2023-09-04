using Ionic.Zip;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using SQLbackup2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace SQLbackup2
{
    public partial class FrmMain : Form
    {
        public string VeriTabaniDosyaYolu { get; set; }
        public Server dbServer { get; set; }
        public List<string> databaseList { get; set; }
        private bool BaglantiAcikMi { get; set; }
        public string LisansAnahtari { get; set; }
        public SqlConnection sqlConnection { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {

            try
            {
                prbIslemler.Value = prbIslemler.Maximum;

                if (string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    string yedekYolu = saveFileDialog1.FileName;
                    DirectoryInfo info = Directory.GetParent(yedekYolu);
                    string connectionString = "Data Source=" + txtServerName.Text + ";Integrated Security=True;"; //Windows auth mode
                    string DizinDosyaYolu = Application.StartupPath + "\\Settings\\Dizin.txt";
                    string[] DizinVeriler = File.ReadAllLines(DizinDosyaYolu);
                    string path = DizinVeriler[0]; // DizinVeriler[0] olarak belirtilen yolun içine atılacak
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string dosyaAdiLog = Path.Combine(path, "Log.txt");

                    if (!File.Exists(dosyaAdiLog))
                    {
                        System.IO.File.Create(dosyaAdiLog).Close();

                    }

                    string sqlVersionQuery = "SELECT @@VERSION AS 'Version'";
                    using (StreamWriter sw = File.AppendText(dosyaAdiLog))
                    {
                        sw.WriteLine("Yedekleme işlemi başarılı!");
                        lstYedekBilgisi.Items.Add("Yedekleme işlemi başarılı!");
                        sw.WriteLine("Yedeklenen dosya: " + yedekYolu);
                        lstYedekBilgisi.Items.Add("Yedeklenen dosya: " + yedekYolu);
                        sw.WriteLine("Yedeklenme tarihi: " + DateTime.Now.ToString());
                        lstYedekBilgisi.Items.Add("Yedeklenme tarihi: " + DateTime.Now.ToString());
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(sqlVersionQuery, con))
                            {
                                try
                                {
                                    con.Open();
                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            string SqlVersion = reader["Version"].ToString();
                                            sw.WriteLine("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                            lstYedekBilgisi.Items.Add("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                                        }
                                        reader.Close();
                                        sw.Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    sw.WriteLine("Hata oluştu: " + ex.Message);
                                    lstYedekBilgisi.Items.Add("Hata oluştu: " + ex.Message.ToString());
                                    lstYedekBilgisi.Items.Add("------------------------------------------------");
                                    sw.Close();
                                }
                            }
                        }
                    }

                }
                else
                {

                    string yedekYolu = saveFileDialog1.FileName;
                    DirectoryInfo info = Directory.GetParent(yedekYolu);
                    string DizinDosyaYolu = Application.StartupPath + "\\Settings\\Dizin.txt";
                    string[] DizinVeriler = File.ReadAllLines(DizinDosyaYolu);
                    string path = DizinVeriler[0]; // DizinVeriler[0] olarak belirtilen yolun içine atılacak


                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string dosyaAdiLog = Path.Combine(path, "Log.txt");

                    if (!File.Exists(dosyaAdiLog))
                    {
                        System.IO.File.Create(dosyaAdiLog).Close();

                    }
                    string sqlVersionQuery = "SELECT @@VERSION AS 'Version'";
                    string connectionString = "Server=" + txtServerName.Text + ";Database=" + cmbDatabase.Text + ";User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text + ";";
                    using (StreamWriter sw = File.AppendText(dosyaAdiLog))
                    {
                        sw.WriteLine("Yedekleme işlemi başarılı!");
                        lstYedekBilgisi.Items.Add("Yedekleme işlemi başarılı!");
                        sw.WriteLine("Yedeklenen dosya: " + yedekYolu);
                        lstYedekBilgisi.Items.Add("Yedeklenen dosya: " + yedekYolu);
                        sw.WriteLine("Yedeklenme tarihi: " + DateTime.Now.ToString());
                        lstYedekBilgisi.Items.Add("Yedeklenme tarihi: " + DateTime.Now.ToString());

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(sqlVersionQuery, con))
                            {
                                try
                                {
                                    con.Open();
                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            string SqlVersion = reader["Version"].ToString();
                                            sw.WriteLine("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                            lstYedekBilgisi.Items.Add("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                                        }
                                        reader.Close();
                                        sw.Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    sw.WriteLine("Hata oluştu: " + ex.Message);
                                    lstYedekBilgisi.Items.Add("Hata oluştu: " + ex.Message.ToString());
                                    lstYedekBilgisi.Items.Add("------------------------------------------------");
                                    sw.Close();
                                }
                            }
                        }
                    }

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = !string.IsNullOrWhiteSpace(txtServerName.Text);
            if (string.IsNullOrWhiteSpace(txtServerName.Text)) //YENİ EKLENEN 
            {
                btnStart.Enabled = false;
                btnPath.Enabled = false;
                txtPath.Clear();
            }



            if (string.IsNullOrEmpty(txtServerName.Text))
            {
                cmbDatabase.DataSource = null;
                prbIslemler.Value = 0;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string VeriTabaniDosyaYolu = Application.StartupPath + "\\Settings\\VeriTabani.txt";
            string[] VeriTabaniVeriler = File.ReadAllLines(VeriTabaniDosyaYolu);
            Microsoft.Data.SqlClient.SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection();
            if (VeriTabaniVeriler.Length > 0 && (!string.IsNullOrEmpty(txtServerName.Text) && string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text)))
            {
                cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog=" + VeriTabaniVeriler[0].ToString() + ";Integrated Security=True;TrustServerCertificate=True");
            }
            if (VeriTabaniVeriler.Length > 0 && (!string.IsNullOrEmpty(txtServerName.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text)))
            {
                 cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog=" + VeriTabaniVeriler[0].ToString() + "; User Id='" + txtUserName.Text + "';Password='" + txtPassword.Text + "';TrustServerCertificate=True");
            }
            //
            if (VeriTabaniVeriler.Length == 0 && (!string.IsNullOrEmpty(txtServerName.Text) && string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text)))
            {
                cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog='master';Integrated Security=True;TrustServerCertificate=True");
            }
            if (VeriTabaniVeriler.Length== 0 && (!string.IsNullOrEmpty(txtServerName.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text)))
            {
                cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog='master'; User Id='" + txtUserName.Text + "';Password='" + txtPassword.Text + "';TrustServerCertificate=True");
            }
            ///
            try
            {
                if (!string.IsNullOrEmpty(txtServerName.Text) && string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    btnTestConnection.Enabled = true;
                    //
                    cn.Open();
                    ServerConnection scon = new ServerConnection(cn);
                    dbServer = new Server(scon);
                    //
                    databaseList = dbServer.Databases.Cast<Database>().Select(db => db.Name).ToList();
                    cmbDatabase.DataSource = databaseList; // girilen sunucunun databaselerini comboBox 'a aktarma
                }
                if (!string.IsNullOrEmpty(txtServerName.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    cn.Open();
                    ServerConnection scon = new ServerConnection(cn);
                    dbServer = new Server(scon);
                    databaseList = dbServer.Databases.Cast<Database>().Select(db => db.Name).ToList();
                    cmbDatabase.DataSource = databaseList; // girilen sunucunun databaselerini comboBox 'a aktarma
                }
                prbIslemler.Value = prbIslemler.Maximum / 2;
                // MessageBox.Show("Bağlantı Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstYedekBilgisi.Items.Add("Bağlantı Başarılı!");
                lstYedekBilgisi.Items.Add("------------------------------------------------");
                lstYedekBilgisi.Refresh();
                BaglantiAcikMi = true;
                cmbDatabase.Enabled = true;
                chkDizinGetir.Enabled = true;
                btnStart.Enabled = false;
            }
            catch (Exception ex)
            {
                string txtDosyaYolu = Application.StartupPath + "\\HataLog.txt";
                if (!File.Exists(txtDosyaYolu))
                {
                    System.IO.File.Create(txtDosyaYolu).Close();

                }
                using (StreamWriter sw = File.AppendText(txtDosyaYolu))
                {
                    sw.WriteLine("Hata Zamanı:" + DateTime.Now.ToString() + "-" + ex.Message.ToString());
                    sw.Close();
                }
                MessageBox.Show("Bağlantı Bilgileri Yanlış:Hata:" + ex.Message.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LisansKontrol();
            TimerLisans.Interval = 86400000;
            TimerLisans.Enabled = true;
            TimerLisans.Start();

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = !string.IsNullOrWhiteSpace(txtPath.Text);
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                prbIslemler.Value = Convert.ToInt32(prbIslemler.Maximum * 0.75);

                btnStart.Enabled = !string.IsNullOrWhiteSpace(txtPath.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/okannakinns");
        }
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.Items.Count == 0 || cmbDatabase.SelectedIndex == -1)
            {
                btnPath.Enabled = false;
            }
            else
            {
                btnPath.Enabled = true;
            }

        }
        public void BackUp()
        {

            if (BaglantiAcikMi)
            {
                Backup dbBackup = new Backup();
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = cmbDatabase.Text; // Seçilen Database adı 
                dbBackup.Devices.AddDevice(txtPath.Text, DeviceType.File);
                dbBackup.Initialize = false;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackup(dbServer);
            }
        }



        private void dizinKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DizinKaydetForm DizinKaydetForm = new DizinKaydetForm();
            DizinKaydetForm.StartPosition = FormStartPosition.CenterScreen;
            DizinKaydetForm.Show();
        }
        private void BaglantiSec_CheckedChanged(object sender, EventArgs e)
        {
            string DosyaYolu = Application.StartupPath + "\\Settings\\Baglanti.txt";

            if (chkBaglantiGetir.Checked)
            {
                if (File.Exists(DosyaYolu))
                {
                    string[] veriler = File.ReadAllLines(DosyaYolu);

                    if (veriler.Length >= 3)
                    {
                        txtServerName.Text = veriler[0];
                        txtUserName.Text = veriler[1];
                        txtPassword.Text = veriler[2];
                    }
                    else
                    {
                        MessageBox.Show("Aktarılacak bir veri bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı.");
                }
            }
            else
            {
                // Checkbox işaretli değilse alanları temizle
                txtServerName.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string DizinDosyaYolu = Application.StartupPath + "\\Settings\\Dizin.txt";
            string BaglantiDosyaYolu = Application.StartupPath + "\\Settings\\Baglanti.txt";
            string ZamanDosyaYolu = Application.StartupPath + "\\Settings\\Zaman.txt";
            string VeriTabaniDosyaYolu = Application.StartupPath + "\\Settings\\VeriTabani.txt";
            string MailDosyaYolu = Application.StartupPath + "\\Settings\\Mail.txt";
            bool BaglantiTest = false;
            string tarihSaatKlasoru = string.Empty;
            string path = string.Empty;
            string ToEmail = string.Empty;
            if (File.Exists(ZamanDosyaYolu))
            {
                string[] ZamanVeriler = File.ReadAllLines(ZamanDosyaYolu);

                if (ZamanVeriler.Length >= 1)
                {
                    timer1.Interval = Convert.ToInt32(ZamanVeriler[0]);

                }
            }
            if (timer1.Enabled)
            {
                if (File.Exists(ZamanDosyaYolu))
                {
                    string[] ZamanVeriler = File.ReadAllLines(ZamanDosyaYolu);

                    if (ZamanVeriler.Length >= 1)
                    {
                        timer1.Interval = Convert.ToInt32(ZamanVeriler[0]);

                    }

                }
            }
            if (File.Exists(BaglantiDosyaYolu))
            {
                string[] BaglantiVeriler = File.ReadAllLines(BaglantiDosyaYolu);
                if (BaglantiVeriler.Length >= 3)
                {
                    txtServerName.Text = BaglantiVeriler[0];
                    txtUserName.Text = BaglantiVeriler[1];
                    txtPassword.Text = BaglantiVeriler[2];
                }
                btnTestConnection.PerformClick();
            }

            if (chkTopluYedek.Checked)
            {
                File.WriteAllText(VeriTabaniDosyaYolu, string.Empty);
                // databaseList adlı listenin içindeki verileri "VeriTabani.txt" dosyasına yaz
                using (StreamWriter writer = new StreamWriter(VeriTabaniDosyaYolu))
                {
                    foreach (var veri in databaseList)
                    {
                        if (veri != "master" && veri != "model" && veri != "tempdb" && veri != "msdb" && veri != "ReportServer" && veri != "ReportServerTempDB")
                        {
                            writer.WriteLine(veri);
                        }
                    }
                }
                if (File.Exists(VeriTabaniDosyaYolu))
                {
                    string[] VeriTabaniVeriler = File.ReadAllLines(VeriTabaniDosyaYolu);
                    if (File.Exists(DizinDosyaYolu))
                    {
                        string[] DizinVeriler = File.ReadAllLines(DizinDosyaYolu);
                        if (DizinVeriler.Length >= 1)
                        {
                            path = DizinVeriler[0];
                            if (Directory.Exists(path))
                            {
                                tarihSaatKlasoru = Path.Combine(path, DateTime.Now.ToString("dd-MM-yyyy_HH-mm"));
                                Directory.CreateDirectory(tarihSaatKlasoru);
                            }
                        }
                    }
                    foreach (string veritabani in VeriTabaniVeriler)
                    {
                        if (!string.IsNullOrEmpty(veritabani))
                        {
                            BaglantiTest = TestConnection(veritabani);
                            if (BaglantiTest)
                            {

                                string veritabaniKlasoru = tarihSaatKlasoru;
                                Directory.CreateDirectory(veritabaniKlasoru);
                                string dosyaAdi = Path.Combine(veritabaniKlasoru, veritabani + ".bak");
                                txtPath.Text = dosyaAdi;
                                saveFileDialog1.FileName = dosyaAdi;
                                cmbDatabase.Text = veritabani;
                                BackUp();
                                prbIslemler.Value = prbIslemler.Maximum;
                                if (string.IsNullOrWhiteSpace(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
                                {
                                    string yedekYolu = saveFileDialog1.FileName;
                                    DirectoryInfo info = Directory.GetParent(yedekYolu);
                                    string connectionString = "Data Source=" + txtServerName.Text + ";Integrated Security=True;"; //Windows auth mode

                                    if (!Directory.Exists(path))
                                    {
                                        Directory.CreateDirectory(path);
                                    }

                                    string dosyaAdiLog = Path.Combine(path, "Log.txt");

                                    if (!File.Exists(dosyaAdiLog))
                                    {
                                        System.IO.File.Create(dosyaAdiLog).Close();

                                    }
                                    string sqlVersionQuery = "SELECT @@VERSION AS 'Version'";
                                    using (StreamWriter sw = File.AppendText(dosyaAdiLog))
                                    {
                                        sw.WriteLine("Yedekleme işlemi başarılı!");
                                        lstYedekBilgisi.Items.Add("Yedekleme işlemi başarılı!");
                                        sw.WriteLine("Yedeklenen Veri Tabanı: " + veritabani);
                                        lstYedekBilgisi.Items.Add("Yedeklenen Veri Tabanı: " + veritabani);
                                        sw.WriteLine("Yedeklenme tarihi: " + DateTime.Now.ToString());
                                        lstYedekBilgisi.Items.Add("Yedeklenme tarihi: " + DateTime.Now.ToString());

                                        using (SqlConnection con = new SqlConnection(connectionString))
                                        {
                                            using (SqlCommand cmd = new SqlCommand(sqlVersionQuery, con))
                                            {
                                                try
                                                {
                                                    con.Open();
                                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                                    {
                                                        while (reader.Read())
                                                        {
                                                            string SqlVersion = reader["Version"].ToString();
                                                            sw.WriteLine("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                                            lstYedekBilgisi.Items.Add("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                                                            lstYedekBilgisi.Refresh();
                                                        }
                                                        reader.Close();
                                                        sw.Close();
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    sw.WriteLine("Hata oluştu: " + ex.Message);
                                                    lstYedekBilgisi.Items.Add("Hata oluştu: " + ex.Message.ToString());
                                                    lstYedekBilgisi.Items.Add("------------------------------------------------");
                                                    sw.Close();
                                                }
                                            }
                                        }
                                    }

                                }
                                else
                                {

                                    string yedekYolu = saveFileDialog1.FileName;
                                    DirectoryInfo info = Directory.GetParent(yedekYolu);



                                    if (!Directory.Exists(path))
                                    {
                                        Directory.CreateDirectory(path);
                                    }

                                    string dosyaAdiLog = Path.Combine(path, "Log.txt");

                                    if (!File.Exists(dosyaAdiLog))
                                    {
                                        System.IO.File.Create(dosyaAdiLog).Close();

                                    }
                                    string sqlVersionQuery = "SELECT @@VERSION AS 'Version'";
                                    string connectionString = "Server=" + txtServerName.Text + ";Database=" + cmbDatabase.Text + ";User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text + ";";
                                    using (StreamWriter sw = File.AppendText(dosyaAdiLog))
                                    {
                                        sw.WriteLine("Yedekleme işlemi başarılı!");
                                        lstYedekBilgisi.Items.Add("Yedekleme işlemi başarılı!");
                                        sw.WriteLine("Yedeklenen Veri Tabanı: " + veritabani);
                                        lstYedekBilgisi.Items.Add("Yedeklenen Veri Tabanı: " + veritabani);
                                        sw.WriteLine("Yedeklenme tarihi: " + DateTime.Now.ToString());
                                        lstYedekBilgisi.Items.Add("Yedeklenme tarihi: " + DateTime.Now.ToString());


                                        using (SqlConnection con = new SqlConnection(connectionString))
                                        {
                                            using (SqlCommand cmd = new SqlCommand(sqlVersionQuery, con))
                                            {
                                                try
                                                {
                                                    con.Open();
                                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                                    {
                                                        while (reader.Read())
                                                        {
                                                            string SqlVersion = reader["Version"].ToString();
                                                            sw.WriteLine("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                                            lstYedekBilgisi.Items.Add("SQL SERVER Versiyon Bilgileriniz: " + SqlVersion);
                                                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                                                        }
                                                        reader.Close();
                                                        sw.Close();
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    sw.WriteLine("Hata oluştu: " + ex.Message);
                                                    lstYedekBilgisi.Items.Add("Hata oluştu: " + ex.Message.ToString());
                                                    lstYedekBilgisi.Items.Add("------------------------------------------------");
                                                    sw.Close();
                                                }
                                            }
                                        }
                                    }

                                }
                            }

                            else
                            {
                                lstYedekBilgisi.Items.Add("Hata oluştu: Dosya Yolu Bulunamıyor, Yeniden Dosya Yolu Seçip Kayıt Ediniz.");
                                lstYedekBilgisi.Items.Add("------------------------------------------------");
                                return;
                            }

                        }
                    }
                    try
                    {
                        using (ZipFile zip = new ZipFile())
                        {

                            DirectoryInfo directory = new DirectoryInfo(tarihSaatKlasoru);
                            zip.AddDirectory(directory.FullName);
                            zip.Save(string.Format("{0}.zip", directory.FullName));
                        }
                    }
                    catch (Exception ex)
                    {
                        string txtDosyaYolu = Application.StartupPath + "\\HataLog.txt";
                        if (!File.Exists(txtDosyaYolu))
                        {
                            System.IO.File.Create(txtDosyaYolu).Close();

                        }
                        using (StreamWriter sw = File.AppendText(txtDosyaYolu))
                        {
                            sw.WriteLine("Hata Zamanı:" + DateTime.Now.ToString() + "-" + ex.Message.ToString());
                            sw.Close();
                        }

                    }

                    Directory.Delete(tarihSaatKlasoru, true);
                    //Mail
                    if (File.Exists(ZamanDosyaYolu))
                    {
                        string[] mailVeriler = File.ReadAllLines(MailDosyaYolu);

                        if (mailVeriler.Length >= 1)
                        {
                            ToEmail = Convert.ToString(mailVeriler[0]);
                            BasariliMailGonder(ToEmail);
                        }
                    }




                }
                else
                {
                    BasarisizMailGonder(ToEmail);
                    lstYedekBilgisi.Items.Add("Hata oluştu: Veritabanı Bulunamıyor, Yeniden Veritabanı Seçip Kayıt Ediniz.");
                    lstYedekBilgisi.Items.Add("------------------------------------------------");
                }

            }
            else
            {
                if (File.Exists(VeriTabaniDosyaYolu))
                {
                    string[] VeriTabaniVeriler = File.ReadAllLines(VeriTabaniDosyaYolu);

                    if (VeriTabaniVeriler.Length >= 1)
                    {
                        bool sonuc = databaseList.Any(x => x == VeriTabaniVeriler[0]);
                        if (sonuc)
                        {
                            cmbDatabase.Text = VeriTabaniVeriler[0];
                        }
                        if (sonuc == false)
                        {
                            lstYedekBilgisi.Items.Add("Hata oluştu: Veritabanı Bulunamıyor, Yeniden Veritabanı Seçip Kayıt Ediniz.");
                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                            return;
                        }
                    }
                }
                if (File.Exists(DizinDosyaYolu))
                {
                    string[] DizinVeriler = File.ReadAllLines(DizinDosyaYolu);
                    if (DizinVeriler.Length >= 1)
                    {
                        path = DizinVeriler[0];
                        if (Directory.Exists(path))
                        {
                            if (path != string.Empty)
                            {
                                txtPath.Text = path + "\\" + cmbDatabase.Text + "_" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".bak";
                                saveFileDialog1.FileName = txtPath.Text;

                                Thread thread = new Thread(BackUp);
                                thread.Start();
                            }
                        }
                        else
                        {
                            lstYedekBilgisi.Items.Add("Hata oluştu: Dosya Yolu Bulunamıyor, Yeniden Dosya Yolu Seçip Kayıt Ediniz.");
                            lstYedekBilgisi.Items.Add("------------------------------------------------");
                            return;
                        }
                    }
                }

            }




        }








        private void chkZamanlayici_CheckedChanged(object sender, EventArgs e)
        {


            if (chkZamanlayici.Checked)
            {
                lblKalanSure.Visible = true;
                timer2.Start();
                timer1.Start();
                chkTopluYedek.Enabled = false;



            }
            else
            {
                timer1.Stop();
                lblKalanSure.Text = "";
                chkTopluYedek.Enabled = true;


            }

        }





        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(BackUp);
            thread.Start();
        }
        public bool TestConnection(string DatabaseName)
        {
            bool sonuc = false;
            try
            {

                if (!string.IsNullOrEmpty(txtServerName.Text) && string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    btnTestConnection.Enabled = true;
                    //
                    Microsoft.Data.SqlClient.SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog='" + DatabaseName + "';Integrated Security=True;TrustServerCertificate=True");
                    cn.Open();
                    ServerConnection scon = new ServerConnection(cn);
                    dbServer = new Server(scon);
                    //
                    databaseList = dbServer.Databases.Cast<Database>().Select(db => db.Name).ToList();
                    cmbDatabase.DataSource = databaseList; // girilen sunucunun databaselerini comboBox 'a aktarma
                }
                if (!string.IsNullOrEmpty(txtServerName.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    Microsoft.Data.SqlClient.SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection("Data Source=" + txtServerName.Text + ";Initial Catalog='" + DatabaseName + "';User Id='" + txtUserName.Text + "';Password='" + txtPassword.Text + "';TrustServerCertificate=True");
                    cn.Open();
                    ServerConnection scon = new ServerConnection(cn);
                    dbServer = new Server(scon);
                    databaseList = dbServer.Databases.Cast<Database>().Select(db => db.Name).ToList();
                    cmbDatabase.DataSource = databaseList; // girilen sunucunun databaselerini comboBox 'a aktarma
                }
                prbIslemler.Value = prbIslemler.Maximum / 2;
                BaglantiAcikMi = true;
                sonuc = true;


            }
            catch (Exception ex)
            {

                string txtDosyaYolu = Application.StartupPath + "\\HataLog.txt";
                if (!File.Exists(txtDosyaYolu))
                {
                    System.IO.File.Create(txtDosyaYolu).Close();

                }
                using (StreamWriter sw = File.AppendText(txtDosyaYolu))
                {
                    sw.WriteLine("Hata Zamanı:" + DateTime.Now.ToString() + "-" + ex.Message.ToString());
                    sw.Close();
                }
                MessageBox.Show("Bağlantı Bilgileri Yanlış:Hata:" + ex.Message.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return sonuc;
        }

        private void veriTabaniKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeriTabaniKaydet VeriTabaniKaydetForm = new FrmVeriTabaniKaydet();
            VeriTabaniKaydetForm.StartPosition = FormStartPosition.CenterScreen;
            VeriTabaniKaydetForm.ShowDialog();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {

            if (chkDizinGetir.Checked)
            {
                saveFileDialog1.Title = "Yedeklenecek yolu belirtiniz.";
                saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak) | *.bak | Tüm Dosyalar(*.*) | *.*";
                saveFileDialog1.InitialDirectory = txtPath.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) // tamam a tıklanmışsa
                {
                    txtPath.Text = saveFileDialog1.FileName; // dosya yolunu path kısmında gösterme
                }

            }
            else
            {
                saveFileDialog1.Title = "Yedeklenecek yolu belirtiniz.";
                saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak) | *.bak | Tüm Dosyalar(*.*) | *.*";
                saveFileDialog1.InitialDirectory = txtPath.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) // tamam a tıklanmışsa
                {
                    txtPath.Text = saveFileDialog1.FileName; // dosya yolunu path kısmında gösterme
                }
            }
        }

        private void ZamaniKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZamaniKaydet ZamaniKaydetForm = new FrmZamaniKaydet();
            ZamaniKaydetForm.StartPosition = FormStartPosition.CenterScreen;
            ZamaniKaydetForm.ShowDialog();
        }

        private void chkDizinGetir_CheckedChanged(object sender, EventArgs e)
        {
            string DosyaYolu = Application.StartupPath + "\\Settings\\Dizin.txt";


            if (chkDizinGetir.Checked)
            {
                if (File.Exists(DosyaYolu))
                {
                    string[] veriler = File.ReadAllLines(DosyaYolu);

                    if (veriler.Length >= 1)
                    {
                        txtPath.Text = veriler[0];

                    }
                    else
                    {
                        MessageBox.Show("Aktarılacak bir veri bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı.");
                }
            }
            else
            {
                prbIslemler.Value = prbIslemler.Maximum / 2;
                txtPath.Text = "";
            }
            if (!chkDizinGetir.Checked && cmbDatabase.Items.Count == 0)
            {
                prbIslemler.Value = 0;
            }
        }
        // ESTETİK GÖRÜNTÜ AÇISINDAN ASKIYA ALINMIŞTIR. 27.05.2023 -- 09:19 -- Okan AKIN -- Software Developer
        public void ZamanHesapla()
        {
            //string ZamanDosyaYolu = Application.StartupPath + "\\Settings\\Zaman.txt";
            //string[] ZamanVeriler = File.ReadAllLines(ZamanDosyaYolu);
            //int MiliSecond = Convert.ToInt32(ZamanVeriler[0]);
            //DateTime lastTime = new DateTime();
            //lastTime = DateTime.Now.AddMilliseconds(MiliSecond);
            //TimeSpan time = lastTime.Subtract(DateTime.Now);
            //int Secondsdiff = time.Seconds;
            //int Minutesdiff = time.Minutes;
            //int Hoursdiff = time.Hours;
            //int Daysdiff = time.Days;
            //lblKalanSure.Text = "Kalan Yedek Alma Süresi Gün:" + Daysdiff.ToString() + "Saat:" + Hoursdiff.ToString() + "Dakika" + Minutesdiff.ToString() + "Saniye:" + Secondsdiff.ToString();
            lblSimdikiZaman.Text = DateTime.Now.ToString();



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ZamanHesapla);
            thread.Start();


        }

        private void chkTopluYedek_CheckedChanged(object sender, EventArgs e)
        {
            string VeriTabaniDosyaYolu = Application.StartupPath + "\\Settings\\VeriTabani.txt";
            if (chkTopluYedek.Checked)
            {
                File.WriteAllText(VeriTabaniDosyaYolu, string.Empty);
                // databaseList adlı listenin içindeki verileri "VeriTabani.txt" dosyasına yaz
                using (StreamWriter writer = new StreamWriter(VeriTabaniDosyaYolu))
                {
                    foreach (var veri in databaseList)
                    {
                        writer.WriteLine(veri);
                    }
                }
            }
        }

        private void BaglantiyiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantiKaydetForm BaglantiKaydetForm = new BaglantiKaydetForm();
            BaglantiKaydetForm.StartPosition = FormStartPosition.CenterScreen;
            BaglantiKaydetForm.ShowDialog();
        }
        public void BasariliMailGonder(string ToEmail)
        {
            MailAddress to = new MailAddress(ToEmail);
            MailAddress from = new MailAddress("testeposta2023@gmail.com");
            MailMessage email = new MailMessage(from, to);
            email.Subject = "YEDEKLEME YAZILIMI YEDEK BİLDİRİMİ";
            email.Body = DateTime.Now.ToString() + "-" + "Tarihli Yedekleme Dosyası Başarıyla Alınmıştır.";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("testeposta2023@gmail.com", "wztdvthfwntaytrj");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(email);
            }
            catch (Exception ex)
            {

            }
        }
        public void BasarisizMailGonder(string ToEmail)
        {
            MailAddress to = new MailAddress(ToEmail);
            MailAddress from = new MailAddress("testeposta2023@gmail.com");
            MailMessage email = new MailMessage(from, to);
            email.Subject = "YEDEKLEME YAZILIMI YEDEK BİLDİRİMİ";
            email.Body = DateTime.Now.ToString() + "-" + "Tarihli Yedekleme Dosyası Alma İşlemi Başarısız olmuştur.";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.yandex.com.tr";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("testeposta2023@gmail.com", "wztdvthfwntaytrj");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(email);
            }
            catch (Exception ex)
            {

            }
        }
        private void ePostaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMailKaydet frmMail = new FrmMailKaydet();
            frmMail.ShowDialog();
        }

        private void TimerLisans_Tick(object sender, EventArgs e)
        {
            LisansKontrol();
        }
        public void LisansKontrol()
        {
            string LisansDosyaYolu = Application.StartupPath + "\\Settings\\Lisans.txt";
            string[] Lisansveriler = File.ReadAllLines(LisansDosyaYolu);
            Lisans lisans = new Lisans();
            if (Lisansveriler.Length == 1)
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = "Data Source=OKAN-LAPTOP\\OKANAKIN;Initial Catalog=ProgramBilgileri;User ID=okannakinn;Password=123456789";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "UPDATE Lisans SET SunucuTarihi=GETDATE()";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT [Id],[LisansAnahtari],[BaslangicTarihi],[BitisTarihi],[OlusturulmaTarihi],[GuncellenmeTarihi],[Durumu],[MusteriId],[ProgramId],[SunucuTarihi] FROM [ProgramBilgileri].[dbo].[Lisans] Where LisansAnahtari=@LisansAnahtari";
                sqlCommand.Parameters.AddWithValue("@LisansAnahtari", Lisansveriler[0].ToString());
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.HasRows)
                    {
                        lisans.Durumu = Convert.ToInt32(sqlDataReader["Durumu"]);
                        lisans.OlusturulmaTarihi = Convert.ToDateTime(sqlDataReader["OlusturulmaTarihi"]);
                        lisans.GuncellenmeTarihi = Convert.ToDateTime(sqlDataReader["GuncellenmeTarihi"]);
                        lisans.BaslangicTarihi = Convert.ToDateTime(sqlDataReader["BaslangicTarihi"]);
                        lisans.BitisTarihi = Convert.ToDateTime(sqlDataReader["BitisTarihi"]);
                        lisans.LisansAnahtari = Convert.ToString(sqlDataReader["LisansAnahtari"]);
                        lisans.MusteriId = Convert.ToInt32(sqlDataReader["MusteriId"]);
                        lisans.ProgramId = Convert.ToInt32(sqlDataReader["ProgramId"]);
                        lisans.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        lisans.SunucuTarihi = Convert.ToDateTime(sqlDataReader["SunucuTarihi"]);
                    }
                }

                TimeSpan KalanGun = new TimeSpan();
                KalanGun = lisans.SunucuTarihi.Subtract(lisans.BitisTarihi);
                int KalanGunSayisi = KalanGun.Days;
                if (KalanGunSayisi > 0 && KalanGunSayisi <= 3)
                {
                    MessageBox.Show("Programın Lisans Süresi " + lisans.BitisTarihi.ToShortDateString() + "  Tarihinde Dolacaktır." + "\n" + "Yeni Lisans Anahtarı Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FrmLisans frmLisans = new FrmLisans();
                    frmLisans.ShowDialog();
                }
                if (KalanGunSayisi == 0)
                {
                    MessageBox.Show("Programın Lisans Süresi " + lisans.BitisTarihi.ToShortDateString() + "  Tarihinde Dolmuştur", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {

                    dbServer = new Server(new ServerConnection());
                    databaseList = new List<string>();
                    BaglantiAcikMi = false;
                    if (string.IsNullOrEmpty(txtServerName.Text))
                    {
                        btnTestConnection.Enabled = false;
                    }
                    txtPath.ReadOnly = true;
                    chkDizinGetir.Enabled = false;
                    lblKalanSure.Visible = false;
                    lblKalanSure.Text = string.Empty;
                }
            }
        }


        private void İletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIletisim IletisimForm = new FrmIletisim();
            IletisimForm.ShowDialog();
        }


        private void yedekYuklemeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmYedekYukleme YedekYuklemeForm = new FrmYedekYukleme();
            YedekYuklemeForm.ShowDialog();
        }

        private void lisansToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLisans LisansForm = new FrmLisans();
            LisansForm.StartPosition = FormStartPosition.CenterScreen;
            LisansForm.ShowDialog();
        }

        private void lstYedekBilgisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



