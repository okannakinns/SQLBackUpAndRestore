namespace SQLbackup2
{
    partial class FrmYedekYukleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYedekYukleme));
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBaglantiGetir = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRestoreSayi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lboxRestoreDosyalari = new System.Windows.Forms.ListBox();
            this.btnFolderChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServerName.Location = new System.Drawing.Point(178, 37);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(283, 34);
            this.txtServerName.TabIndex = 29;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sunucu IP:";
            // 
            // chkBaglantiGetir
            // 
            this.chkBaglantiGetir.AutoSize = true;
            this.chkBaglantiGetir.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBaglantiGetir.Location = new System.Drawing.Point(180, 4);
            this.chkBaglantiGetir.Name = "chkBaglantiGetir";
            this.chkBaglantiGetir.Size = new System.Drawing.Size(158, 36);
            this.chkBaglantiGetir.TabIndex = 27;
            this.chkBaglantiGetir.Text = "Bağlantı Getir";
            this.chkBaglantiGetir.UseVisualStyleBackColor = true;
            this.chkBaglantiGetir.CheckedChanged += new System.EventHandler(this.chkBaglantiGetir_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(62, 464);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(851, 50);
            this.progressBar1.TabIndex = 26;
            // 
            // lblRestoreSayi
            // 
            this.lblRestoreSayi.AutoSize = true;
            this.lblRestoreSayi.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoreSayi.Location = new System.Drawing.Point(510, 39);
            this.lblRestoreSayi.Name = "lblRestoreSayi";
            this.lblRestoreSayi.Size = new System.Drawing.Size(324, 32);
            this.lblRestoreSayi.TabIndex = 25;
            this.lblRestoreSayi.Text = "0  Adet Veritabanı Restore Edilecek";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(65, 420);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(141, 32);
            this.lblDurum.TabIndex = 24;
            this.lblDurum.Text = "İşlem Durumu";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(353, 344);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(216, 67);
            this.btnRestore.TabIndex = 23;
            this.btnRestore.Text = "İşlemi Başlat";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lboxRestoreDosyalari
            // 
            this.lboxRestoreDosyalari.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxRestoreDosyalari.FormattingEnabled = true;
            this.lboxRestoreDosyalari.ItemHeight = 30;
            this.lboxRestoreDosyalari.Location = new System.Drawing.Point(62, 84);
            this.lboxRestoreDosyalari.Name = "lboxRestoreDosyalari";
            this.lboxRestoreDosyalari.Size = new System.Drawing.Size(851, 244);
            this.lboxRestoreDosyalari.TabIndex = 22;
            // 
            // btnFolderChoose
            // 
            this.btnFolderChoose.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFolderChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderChoose.Image")));
            this.btnFolderChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolderChoose.Location = new System.Drawing.Point(62, 344);
            this.btnFolderChoose.Name = "btnFolderChoose";
            this.btnFolderChoose.Size = new System.Drawing.Size(276, 67);
            this.btnFolderChoose.TabIndex = 21;
            this.btnFolderChoose.Text = "Yedek Dosyalarını Seç";
            this.btnFolderChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFolderChoose.UseVisualStyleBackColor = true;
            this.btnFolderChoose.Click += new System.EventHandler(this.btnFolderChoose_Click);
            // 
            // FrmYedekYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBaglantiGetir);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblRestoreSayi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.lboxRestoreDosyalari);
            this.Controls.Add(this.btnFolderChoose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmYedekYukleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedek Yükleme";
            this.Load += new System.EventHandler(this.FrmYedekYukleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBaglantiGetir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblRestoreSayi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ListBox lboxRestoreDosyalari;
        private System.Windows.Forms.Button btnFolderChoose;
    }
}