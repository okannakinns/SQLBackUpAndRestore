using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Smo;

namespace SQLbackup2
{
    public partial class FrmYedekYukleme : Form
    {
        public string DosyaYolu { get; set; }
        public bool restoreSuccess { get; set; }
        public FrmYedekYukleme()
        {
            InitializeComponent();
        }

        private void FrmYedekYukleme_Load(object sender, EventArgs e)
        {
            DosyaYolu = Application.StartupPath + "\\Settings\\Baglanti.txt";
            lblRestoreSayi.Visible = false;

            btnFolderChoose.Enabled = false;
            btnRestore.Enabled = false;
        }
        private void RestoreDatabase(string connectionString, string FromFileName,string ToFileName, string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string LogicalNameData = string.Empty;
                    string LogicalNameLog = string.Empty;
                    int Sayi = 0;
                    SqlCommand sqlCommand = new SqlCommand("RESTORE FILELISTONLY from disk='" + FromFileName + "'",connection);
                    SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while(sqlDataReader.Read())
                        {
                            if(Sayi==0)
                            {
                                LogicalNameData = Convert.ToString(sqlDataReader["LogicalName"]);
                                Sayi++;

                            }
                            if(Sayi==1)
                            {
                                LogicalNameLog = Convert.ToString(sqlDataReader["LogicalName"]);
                            }
                        }
                        sqlDataReader.Close();
                    }
                    string restoreQuery = $" USE [master] RESTORE DATABASE [{databaseName}] FROM DISK = N'{FromFileName}' WITH FILE =1, MOVE";
                    restoreQuery = restoreQuery + " N'" + LogicalNameData + "' TO N'"+ToFileName+"\\"+databaseName+".MDF', MOVE ";
                    restoreQuery = restoreQuery + " N'" + LogicalNameLog + "' TO N'" + ToFileName + "\\" + databaseName + "_LOG" + ".LDF";
                    restoreQuery = restoreQuery + "', NOUNLOAD ,STATS=5";
                    // Geri yükleme sorgusu oluştur
                    //USE [master]
                    //RESTORE DATABASE[ADEM_BULUT_2022] FROM DISK = N'C:\05-06-2023_14-47\ADEM_BULUT_2022.bak' WITH FILE = 1, MOVE ////N'kurulum_firmayil_Data' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\2022.MDF',  MOVE N'kurulum_firmayil_Log' TO N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\2022_LOG.LDF',  NOUNLOAD,  STATS = 5 
                    using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        restoreSuccess = true;
                    }
                }
                catch (Exception ex)
                {
                    restoreSuccess = false;
                    // Hata durumunda işlemi ele al
                    MessageBox.Show($"Geri yükleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnFolderChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Backup Files (*.bak)|*.bak";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnRestore.Enabled = true;
                lblRestoreSayi.Visible = true;
                string[] fileNames = openFileDialog.FileNames;
                string restoreFilePath = Application.StartupPath + "\\Settings\\Restore.txt";

                // Seçilen dosyaları Restore.txt dosyasına yaz
                File.WriteAllLines(restoreFilePath, fileNames);

                // ListBox'a dosyaları ekle
                lboxRestoreDosyalari.Items.Clear();
                for (int i = 0; i < fileNames.Length; i++)
                {
                    string fileName = Path.GetFileName(fileNames[i]);
                    lboxRestoreDosyalari.Items.Add((i + 1) + "-  " + fileName);
                    lblRestoreSayi.Text = fileNames.Length.ToString() + " Adet Veritabanı Restore Edilecek";
                }
            }
        }

        private void chkBaglantiGetir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaglantiGetir.Checked)
            {
                if (File.Exists(DosyaYolu))
                {
                    string[] veriler = File.ReadAllLines(DosyaYolu);

                    if (veriler.Length >= 1)
                    {
                        txtServerName.Text = veriler[0];

                    }
                    else
                    {
                        MessageBox.Show("Aktarılacak bir veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Checkbox işaretli değilse alanları temizle
                txtServerName.Text = "";
                MessageBox.Show("Veri aktarımı iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            string serverName = txtServerName.Text;
            string restoreFilePath = Path.Combine(Application.StartupPath, "Settings", "Restore.txt");
            if (File.Exists(restoreFilePath))
            {
                string[] fileNames = File.ReadAllLines(restoreFilePath);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = fileNames.Length;
                progressBar1.Value = 0;
                string SqlconnectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(SqlconnectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM sys.master_files",sqlConnection);
                SqlDataReader sqlDataReader= command.ExecuteReader();
                string SqlBackUpFilePath = string.Empty;
                if (sqlDataReader.HasRows)
                {
                    while(sqlDataReader.Read())
                    {
                        SqlBackUpFilePath=Convert.ToString(sqlDataReader["physical_name"]);
                        break;
                    }
                }
                sqlDataReader.Close();
                FileInfo fileInfo = new FileInfo(SqlBackUpFilePath);
                string FileBackUpParentFolder=fileInfo.DirectoryName;
                if (progressBar1.Value >= 0)
                {

                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        string fileName = fileNames[i];
                        string databaseName = Path.GetFileNameWithoutExtension(fileName);
                        // Geri yükleme işlemini gerçekleştir
                        RestoreDatabase(SqlconnectionString, fileName, FileBackUpParentFolder, databaseName);
                        lblDurum.Text = $"Restore Ediliyor... ({i + 1}/{fileNames.Length})";
                        lblDurum.Refresh();
                        progressBar1.Value = i + 1;
                        if (restoreSuccess == false)
                        {
                            break; // İşlemi sonlandır

                        }

                    }
                }
                if (restoreSuccess)
                {
                    lblDurum.Text = "Restore İşlemi Tamamlandı.";
                    progressBar1.Value = progressBar1.Maximum;
                    MessageBox.Show("Restore İşlemi Tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblDurum.Text = "Restore İşlemi Başarısız.";
                    progressBar1.Value = progressBar1.Minimum;
                    MessageBox.Show("Restore İşlemi Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Restore.txt dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServerName.Text))
            {
                btnFolderChoose.Enabled = true;

            }
            else
            {
                btnFolderChoose.Enabled = false;
                btnRestore.Enabled = false;
            }
        }
    }
}
