namespace SQLbackup2
{
    partial class FrmVeriTabaniKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeriTabaniKaydet));
            this.VeriTabaniVazgecBtn = new System.Windows.Forms.Button();
            this.VeriTabaniTemizleBtn = new System.Windows.Forms.Button();
            this.VeriTabaniKaydetBtn = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VeriTabaniVazgecBtn
            // 
            this.VeriTabaniVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriTabaniVazgecBtn.Image = ((System.Drawing.Image)(resources.GetObject("VeriTabaniVazgecBtn.Image")));
            this.VeriTabaniVazgecBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeriTabaniVazgecBtn.Location = new System.Drawing.Point(283, 106);
            this.VeriTabaniVazgecBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniVazgecBtn.Name = "VeriTabaniVazgecBtn";
            this.VeriTabaniVazgecBtn.Size = new System.Drawing.Size(90, 62);
            this.VeriTabaniVazgecBtn.TabIndex = 11;
            this.VeriTabaniVazgecBtn.Text = "Vazgeç";
            this.VeriTabaniVazgecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VeriTabaniVazgecBtn.UseVisualStyleBackColor = true;
            this.VeriTabaniVazgecBtn.Click += new System.EventHandler(this.VeriTabaniVazgecBtn_Click);
            // 
            // VeriTabaniTemizleBtn
            // 
            this.VeriTabaniTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriTabaniTemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("VeriTabaniTemizleBtn.Image")));
            this.VeriTabaniTemizleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeriTabaniTemizleBtn.Location = new System.Drawing.Point(191, 107);
            this.VeriTabaniTemizleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniTemizleBtn.Name = "VeriTabaniTemizleBtn";
            this.VeriTabaniTemizleBtn.Size = new System.Drawing.Size(90, 62);
            this.VeriTabaniTemizleBtn.TabIndex = 10;
            this.VeriTabaniTemizleBtn.Text = "Temizle";
            this.VeriTabaniTemizleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VeriTabaniTemizleBtn.UseVisualStyleBackColor = true;
            this.VeriTabaniTemizleBtn.Click += new System.EventHandler(this.VeriTabaniTemizleBtn_Click);
            // 
            // VeriTabaniKaydetBtn
            // 
            this.VeriTabaniKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriTabaniKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("VeriTabaniKaydetBtn.Image")));
            this.VeriTabaniKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeriTabaniKaydetBtn.Location = new System.Drawing.Point(98, 107);
            this.VeriTabaniKaydetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniKaydetBtn.Name = "VeriTabaniKaydetBtn";
            this.VeriTabaniKaydetBtn.Size = new System.Drawing.Size(90, 62);
            this.VeriTabaniKaydetBtn.TabIndex = 9;
            this.VeriTabaniKaydetBtn.Text = "Kaydet";
            this.VeriTabaniKaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VeriTabaniKaydetBtn.UseVisualStyleBackColor = true;
            this.VeriTabaniKaydetBtn.Click += new System.EventHandler(this.VeriTabaniKaydetBtn_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDatabase.Location = new System.Drawing.Point(105, 44);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(261, 29);
            this.txtDatabase.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Veri Tabanı:";
            // 
            // FrmVeriTabaniKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.VeriTabaniVazgecBtn);
            this.Controls.Add(this.VeriTabaniTemizleBtn);
            this.Controls.Add(this.VeriTabaniKaydetBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmVeriTabaniKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tabanı Kaydet";
            this.Load += new System.EventHandler(this.VeriTabaniKaydetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VeriTabaniVazgecBtn;
        private System.Windows.Forms.Button VeriTabaniTemizleBtn;
        private System.Windows.Forms.Button VeriTabaniKaydetBtn;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label1;
    }
}