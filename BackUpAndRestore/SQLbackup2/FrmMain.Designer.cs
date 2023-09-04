namespace SQLbackup2
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBaglantiGetir = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDizinGetir = new System.Windows.Forms.CheckBox();
            this.prbIslemler = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAyarlar = new System.Windows.Forms.ToolStripDropDownButton();
            this.ZamaniKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaglantiyiKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DizinKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTabaniKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePostaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lisansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekYuklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDestek = new System.Windows.Forms.ToolStripDropDownButton();
            this.IletisimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkZamanlayici = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstYedekBilgisi = new System.Windows.Forms.ListBox();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSimdikiZaman = new System.Windows.Forms.Label();
            this.chkTopluYedek = new System.Windows.Forms.CheckBox();
            this.TimerLisans = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veri Tabanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kayıt Dizini:";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServerName.Location = new System.Drawing.Point(159, 34);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(261, 30);
            this.txtServerName.TabIndex = 3;
            this.txtServerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPath.Location = new System.Drawing.Point(159, 74);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(331, 30);
            this.txtPath.TabIndex = 5;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(229, 110);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 86);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Başlat";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.White;
            this.btnPath.Enabled = false;
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPath.Image = ((System.Drawing.Image)(resources.GetObject("btnPath.Image")));
            this.btnPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPath.Location = new System.Drawing.Point(496, 34);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(104, 71);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "Gözat";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(159, 70);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 30);
            this.txtUserName.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(159, 106);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 30);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownHeight = 150;
            this.cmbDatabase.DropDownWidth = 121;
            this.cmbDatabase.Enabled = false;
            this.cmbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.IntegralHeight = false;
            this.cmbDatabase.ItemHeight = 25;
            this.cmbDatabase.Location = new System.Drawing.Point(159, 34);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDatabase.MaxDropDownItems = 20;
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(331, 33);
            this.cmbDatabase.TabIndex = 14;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConnection.Image")));
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTestConnection.Location = new System.Drawing.Point(427, 70);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(165, 70);
            this.btnTestConnection.TabIndex = 15;
            this.btnTestConnection.Text = "Bağlantı Test";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBaglantiGetir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.btnTestConnection);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(697, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunucu Bilgileri";
            // 
            // chkBaglantiGetir
            // 
            this.chkBaglantiGetir.AutoSize = true;
            this.chkBaglantiGetir.Location = new System.Drawing.Point(427, 33);
            this.chkBaglantiGetir.Margin = new System.Windows.Forms.Padding(4);
            this.chkBaglantiGetir.Name = "chkBaglantiGetir";
            this.chkBaglantiGetir.Size = new System.Drawing.Size(164, 29);
            this.chkBaglantiGetir.TabIndex = 16;
            this.chkBaglantiGetir.Text = "Bağlantı Getir";
            this.chkBaglantiGetir.UseVisualStyleBackColor = true;
            this.chkBaglantiGetir.CheckedChanged += new System.EventHandler(this.BaglantiSec_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDizinGetir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDatabase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.btnPath);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(697, 199);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedek Alınacak Veritabanı Bilgileri";
            // 
            // chkDizinGetir
            // 
            this.chkDizinGetir.AutoSize = true;
            this.chkDizinGetir.Location = new System.Drawing.Point(5, 122);
            this.chkDizinGetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDizinGetir.Name = "chkDizinGetir";
            this.chkDizinGetir.Size = new System.Drawing.Size(134, 29);
            this.chkDizinGetir.TabIndex = 15;
            this.chkDizinGetir.Text = "Dizin Getir";
            this.chkDizinGetir.UseVisualStyleBackColor = true;
            this.chkDizinGetir.CheckedChanged += new System.EventHandler(this.chkDizinGetir_CheckedChanged);
            // 
            // prbIslemler
            // 
            this.prbIslemler.Location = new System.Drawing.Point(15, 503);
            this.prbIslemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prbIslemler.Name = "prbIslemler";
            this.prbIslemler.Size = new System.Drawing.Size(1056, 38);
            this.prbIslemler.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(1076, 516);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 22);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Okan Akın © ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainToolStrip.GripMargin = new System.Windows.Forms.Padding(6, 1, 1, 1);
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAyarlar,
            this.toolStripLabel1,
            this.toolStripDestek});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MainToolStrip.Size = new System.Drawing.Size(1257, 34);
            this.MainToolStrip.TabIndex = 20;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripAyarlar
            // 
            this.toolStripAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZamaniKaydetToolStripMenuItem,
            this.BaglantiyiKaydetToolStripMenuItem,
            this.DizinKaydetToolStripMenuItem,
            this.veriTabaniKaydetToolStripMenuItem,
            this.ePostaKaydetToolStripMenuItem});
            this.toolStripAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAyarlar.Image")));
            this.toolStripAyarlar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripAyarlar.Name = "toolStripAyarlar";
            this.toolStripAyarlar.Size = new System.Drawing.Size(108, 29);
            this.toolStripAyarlar.Text = "Ayarlar";
            // 
            // ZamaniKaydetToolStripMenuItem
            // 
            this.ZamaniKaydetToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ZamaniKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ZamaniKaydetToolStripMenuItem.Image")));
            this.ZamaniKaydetToolStripMenuItem.Name = "ZamaniKaydetToolStripMenuItem";
            this.ZamaniKaydetToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.ZamaniKaydetToolStripMenuItem.Text = "Zamanı kaydet";
            this.ZamaniKaydetToolStripMenuItem.Click += new System.EventHandler(this.ZamaniKaydetToolStripMenuItem_Click);
            // 
            // BaglantiyiKaydetToolStripMenuItem
            // 
            this.BaglantiyiKaydetToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.BaglantiyiKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BaglantiyiKaydetToolStripMenuItem.Image")));
            this.BaglantiyiKaydetToolStripMenuItem.Name = "BaglantiyiKaydetToolStripMenuItem";
            this.BaglantiyiKaydetToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.BaglantiyiKaydetToolStripMenuItem.Text = "Bağlantıyı kaydet";
            this.BaglantiyiKaydetToolStripMenuItem.Click += new System.EventHandler(this.BaglantiyiKaydetToolStripMenuItem_Click);
            // 
            // DizinKaydetToolStripMenuItem
            // 
            this.DizinKaydetToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DizinKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DizinKaydetToolStripMenuItem.Image")));
            this.DizinKaydetToolStripMenuItem.Name = "DizinKaydetToolStripMenuItem";
            this.DizinKaydetToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.DizinKaydetToolStripMenuItem.Text = "Dizin Kaydet";
            this.DizinKaydetToolStripMenuItem.Click += new System.EventHandler(this.dizinKaydetToolStripMenuItem_Click);
            // 
            // veriTabaniKaydetToolStripMenuItem
            // 
            this.veriTabaniKaydetToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.veriTabaniKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veriTabaniKaydetToolStripMenuItem.Image")));
            this.veriTabaniKaydetToolStripMenuItem.Name = "veriTabaniKaydetToolStripMenuItem";
            this.veriTabaniKaydetToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.veriTabaniKaydetToolStripMenuItem.Text = "Veri Tabanı Kaydet";
            this.veriTabaniKaydetToolStripMenuItem.Click += new System.EventHandler(this.veriTabaniKaydetToolStripMenuItem_Click);
            // 
            // ePostaKaydetToolStripMenuItem
            // 
            this.ePostaKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ePostaKaydetToolStripMenuItem.Image")));
            this.ePostaKaydetToolStripMenuItem.Name = "ePostaKaydetToolStripMenuItem";
            this.ePostaKaydetToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.ePostaKaydetToolStripMenuItem.Text = "E-Posta Kaydet";
            this.ePostaKaydetToolStripMenuItem.Click += new System.EventHandler(this.ePostaKaydetToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisansToolStripMenuItem,
            this.yedekYuklemeToolStripMenuItem});
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 31);
            this.toolStripLabel1.Text = "İşlemler";
            // 
            // lisansToolStripMenuItem
            // 
            this.lisansToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lisansToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lisansToolStripMenuItem.Image")));
            this.lisansToolStripMenuItem.Name = "lisansToolStripMenuItem";
            this.lisansToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.lisansToolStripMenuItem.Text = "Lisans";
            this.lisansToolStripMenuItem.Click += new System.EventHandler(this.lisansToolStripMenuItem_Click_1);
            // 
            // yedekYuklemeToolStripMenuItem
            // 
            this.yedekYuklemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yedekYuklemeToolStripMenuItem.Image")));
            this.yedekYuklemeToolStripMenuItem.Name = "yedekYuklemeToolStripMenuItem";
            this.yedekYuklemeToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.yedekYuklemeToolStripMenuItem.Text = "Yedek Yükleme";
            this.yedekYuklemeToolStripMenuItem.Click += new System.EventHandler(this.yedekYuklemeToolStripMenuItem_Click_1);
            // 
            // toolStripDestek
            // 
            this.toolStripDestek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IletisimToolStripMenuItem});
            this.toolStripDestek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripDestek.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDestek.Image")));
            this.toolStripDestek.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolStripDestek.Name = "toolStripDestek";
            this.toolStripDestek.Size = new System.Drawing.Size(107, 31);
            this.toolStripDestek.Text = "Destek";
            // 
            // IletisimToolStripMenuItem
            // 
            this.IletisimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IletisimToolStripMenuItem.Image")));
            this.IletisimToolStripMenuItem.Name = "IletisimToolStripMenuItem";
            this.IletisimToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.IletisimToolStripMenuItem.Text = "İletişim";
            this.IletisimToolStripMenuItem.Click += new System.EventHandler(this.İletisimToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkZamanlayici
            // 
            this.chkZamanlayici.AutoSize = true;
            this.chkZamanlayici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkZamanlayici.Location = new System.Drawing.Point(15, 398);
            this.chkZamanlayici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkZamanlayici.Name = "chkZamanlayici";
            this.chkZamanlayici.Size = new System.Drawing.Size(222, 29);
            this.chkZamanlayici.TabIndex = 16;
            this.chkZamanlayici.Text = "Zamanlayıcı Çalıştır";
            this.chkZamanlayici.UseVisualStyleBackColor = true;
            this.chkZamanlayici.CheckedChanged += new System.EventHandler(this.chkZamanlayici_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstYedekBilgisi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(719, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(523, 396);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yedek Bilgisi";
            // 
            // lstYedekBilgisi
            // 
            this.lstYedekBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYedekBilgisi.FormattingEnabled = true;
            this.lstYedekBilgisi.ItemHeight = 17;
            this.lstYedekBilgisi.Location = new System.Drawing.Point(8, 26);
            this.lstYedekBilgisi.Margin = new System.Windows.Forms.Padding(4);
            this.lstYedekBilgisi.Name = "lstYedekBilgisi";
            this.lstYedekBilgisi.Size = new System.Drawing.Size(505, 327);
            this.lstYedekBilgisi.TabIndex = 0;
            this.lstYedekBilgisi.SelectedIndexChanged += new System.EventHandler(this.lstYedekBilgisi_SelectedIndexChanged);
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.Location = new System.Drawing.Point(16, 438);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(41, 20);
            this.lblKalanSure.TabIndex = 22;
            this.lblKalanSure.Text = "test";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSimdikiZaman
            // 
            this.lblSimdikiZaman.AutoSize = true;
            this.lblSimdikiZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSimdikiZaman.Location = new System.Drawing.Point(16, 469);
            this.lblSimdikiZaman.Name = "lblSimdikiZaman";
            this.lblSimdikiZaman.Size = new System.Drawing.Size(41, 20);
            this.lblSimdikiZaman.TabIndex = 23;
            this.lblSimdikiZaman.Text = "test";
            // 
            // chkTopluYedek
            // 
            this.chkTopluYedek.AutoSize = true;
            this.chkTopluYedek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTopluYedek.Location = new System.Drawing.Point(492, 398);
            this.chkTopluYedek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTopluYedek.Name = "chkTopluYedek";
            this.chkTopluYedek.Size = new System.Drawing.Size(156, 29);
            this.chkTopluYedek.TabIndex = 16;
            this.chkTopluYedek.Text = "Toplu Yedek";
            this.chkTopluYedek.UseVisualStyleBackColor = true;
            this.chkTopluYedek.CheckedChanged += new System.EventHandler(this.chkTopluYedek_CheckedChanged);
            // 
            // TimerLisans
            // 
            this.TimerLisans.Interval = 86400000;
            this.TimerLisans.Tick += new System.EventHandler(this.TimerLisans_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 548);
            this.Controls.Add(this.chkTopluYedek);
            this.Controls.Add(this.lblSimdikiZaman);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkZamanlayici);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.prbIslemler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Yedekleme İşlemleri";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar prbIslemler;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkBaglantiGetir;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripAyarlar;
        private System.Windows.Forms.ToolStripMenuItem ZamaniKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaglantiyiKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DizinKaydetToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkDizinGetir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkZamanlayici;
        private System.Windows.Forms.ToolStripMenuItem veriTabaniKaydetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstYedekBilgisi;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSimdikiZaman;
        private System.Windows.Forms.CheckBox chkTopluYedek;
        private System.Windows.Forms.ToolStripMenuItem ePostaKaydetToolStripMenuItem;
        public System.Windows.Forms.Timer TimerLisans;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDestek;
        private System.Windows.Forms.ToolStripMenuItem IletisimToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem yedekYuklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisansToolStripMenuItem;
    }
}

