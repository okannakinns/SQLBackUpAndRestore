namespace SQLbackup2
{
    partial class FrmMailKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailKaydet));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.VeriTabaniVazgecBtn = new System.Windows.Forms.Button();
            this.VeriTabaniTemizleBtn = new System.Windows.Forms.Button();
            this.VeriTabaniKaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "E-Mail:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDatabase.Location = new System.Drawing.Point(78, 29);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(261, 29);
            this.txtDatabase.TabIndex = 23;
            // 
            // VeriTabaniVazgecBtn
            // 
            this.VeriTabaniVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriTabaniVazgecBtn.Image = ((System.Drawing.Image)(resources.GetObject("VeriTabaniVazgecBtn.Image")));
            this.VeriTabaniVazgecBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeriTabaniVazgecBtn.Location = new System.Drawing.Point(249, 78);
            this.VeriTabaniVazgecBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniVazgecBtn.Name = "VeriTabaniVazgecBtn";
            this.VeriTabaniVazgecBtn.Size = new System.Drawing.Size(90, 64);
            this.VeriTabaniVazgecBtn.TabIndex = 22;
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
            this.VeriTabaniTemizleBtn.Location = new System.Drawing.Point(157, 79);
            this.VeriTabaniTemizleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniTemizleBtn.Name = "VeriTabaniTemizleBtn";
            this.VeriTabaniTemizleBtn.Size = new System.Drawing.Size(90, 64);
            this.VeriTabaniTemizleBtn.TabIndex = 21;
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
            this.VeriTabaniKaydetBtn.Location = new System.Drawing.Point(64, 79);
            this.VeriTabaniKaydetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VeriTabaniKaydetBtn.Name = "VeriTabaniKaydetBtn";
            this.VeriTabaniKaydetBtn.Size = new System.Drawing.Size(90, 64);
            this.VeriTabaniKaydetBtn.TabIndex = 20;
            this.VeriTabaniKaydetBtn.Text = "Kaydet";
            this.VeriTabaniKaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VeriTabaniKaydetBtn.UseVisualStyleBackColor = true;
            this.VeriTabaniKaydetBtn.Click += new System.EventHandler(this.VeriTabaniKaydetBtn_Click);
            // 
            // FrmMailKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.VeriTabaniVazgecBtn);
            this.Controls.Add(this.VeriTabaniTemizleBtn);
            this.Controls.Add(this.VeriTabaniKaydetBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMailKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Kaydet";
            this.Load += new System.EventHandler(this.FrmMailKaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Button VeriTabaniVazgecBtn;
        private System.Windows.Forms.Button VeriTabaniTemizleBtn;
        private System.Windows.Forms.Button VeriTabaniKaydetBtn;
    }
}