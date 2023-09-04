namespace SQLbackup2
{
    partial class FrmZamaniKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZamaniKaydet));
            this.ZamanNumericUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ZamanVazgecBtn = new System.Windows.Forms.Button();
            this.ZamanTemizleBtn = new System.Windows.Forms.Button();
            this.ZamanKaydetBtn = new System.Windows.Forms.Button();
            this.cmbZamanlar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ZamanNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ZamanNumericUD
            // 
            this.ZamanNumericUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ZamanNumericUD.Location = new System.Drawing.Point(122, 42);
            this.ZamanNumericUD.Margin = new System.Windows.Forms.Padding(2);
            this.ZamanNumericUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ZamanNumericUD.Name = "ZamanNumericUD";
            this.ZamanNumericUD.Size = new System.Drawing.Size(65, 26);
            this.ZamanNumericUD.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zaman:";
            // 
            // ZamanVazgecBtn
            // 
            this.ZamanVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamanVazgecBtn.Image = ((System.Drawing.Image)(resources.GetObject("ZamanVazgecBtn.Image")));
            this.ZamanVazgecBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZamanVazgecBtn.Location = new System.Drawing.Point(257, 87);
            this.ZamanVazgecBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ZamanVazgecBtn.Name = "ZamanVazgecBtn";
            this.ZamanVazgecBtn.Size = new System.Drawing.Size(90, 65);
            this.ZamanVazgecBtn.TabIndex = 16;
            this.ZamanVazgecBtn.Text = "Vazgeç";
            this.ZamanVazgecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZamanVazgecBtn.UseVisualStyleBackColor = true;
            this.ZamanVazgecBtn.Click += new System.EventHandler(this.ZamanVazgecBtn_Click);
            // 
            // ZamanTemizleBtn
            // 
            this.ZamanTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamanTemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ZamanTemizleBtn.Image")));
            this.ZamanTemizleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZamanTemizleBtn.Location = new System.Drawing.Point(164, 86);
            this.ZamanTemizleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ZamanTemizleBtn.Name = "ZamanTemizleBtn";
            this.ZamanTemizleBtn.Size = new System.Drawing.Size(90, 65);
            this.ZamanTemizleBtn.TabIndex = 15;
            this.ZamanTemizleBtn.Text = "Temizle";
            this.ZamanTemizleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZamanTemizleBtn.UseVisualStyleBackColor = true;
            this.ZamanTemizleBtn.Click += new System.EventHandler(this.ZamanTemizleBtn_Click);
            // 
            // ZamanKaydetBtn
            // 
            this.ZamanKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamanKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("ZamanKaydetBtn.Image")));
            this.ZamanKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZamanKaydetBtn.Location = new System.Drawing.Point(72, 87);
            this.ZamanKaydetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ZamanKaydetBtn.Name = "ZamanKaydetBtn";
            this.ZamanKaydetBtn.Size = new System.Drawing.Size(90, 65);
            this.ZamanKaydetBtn.TabIndex = 14;
            this.ZamanKaydetBtn.Text = "Kaydet";
            this.ZamanKaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZamanKaydetBtn.UseVisualStyleBackColor = true;
            this.ZamanKaydetBtn.Click += new System.EventHandler(this.ZamanKaydetBtn_Click);
            // 
            // cmbZamanlar
            // 
            this.cmbZamanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbZamanlar.FormattingEnabled = true;
            this.cmbZamanlar.Location = new System.Drawing.Point(191, 41);
            this.cmbZamanlar.Name = "cmbZamanlar";
            this.cmbZamanlar.Size = new System.Drawing.Size(121, 28);
            this.cmbZamanlar.TabIndex = 19;
            // 
            // FrmZamaniKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 184);
            this.Controls.Add(this.cmbZamanlar);
            this.Controls.Add(this.ZamanNumericUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZamanVazgecBtn);
            this.Controls.Add(this.ZamanTemizleBtn);
            this.Controls.Add(this.ZamanKaydetBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmZamaniKaydet";
            this.Text = "Zaman Kaydetme";
            this.Load += new System.EventHandler(this.ZamaniKaydetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZamanNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ZamanNumericUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ZamanVazgecBtn;
        private System.Windows.Forms.Button ZamanTemizleBtn;
        private System.Windows.Forms.Button ZamanKaydetBtn;
        private System.Windows.Forms.ComboBox cmbZamanlar;
    }
}