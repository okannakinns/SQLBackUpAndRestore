namespace SQLbackup2
{
    partial class DizinKaydetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DizinKaydetForm));
            this.label4 = new System.Windows.Forms.Label();
            this.dizinKaydetBtn = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dizinTemizleBtn = new System.Windows.Forms.Button();
            this.dizinVazgecBtn = new System.Windows.Forms.Button();
            this.dizinGozatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kaydedilecek Dizin";
            // 
            // dizinKaydetBtn
            // 
            this.dizinKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizinKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("dizinKaydetBtn.Image")));
            this.dizinKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dizinKaydetBtn.Location = new System.Drawing.Point(8, 93);
            this.dizinKaydetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dizinKaydetBtn.Name = "dizinKaydetBtn";
            this.dizinKaydetBtn.Size = new System.Drawing.Size(90, 67);
            this.dizinKaydetBtn.TabIndex = 14;
            this.dizinKaydetBtn.Text = "Kaydet";
            this.dizinKaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dizinKaydetBtn.UseVisualStyleBackColor = true;
            this.dizinKaydetBtn.Click += new System.EventHandler(this.dizinKaydetBtn_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPath.Location = new System.Drawing.Point(9, 46);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(280, 29);
            this.txtPath.TabIndex = 17;
            // 
            // dizinTemizleBtn
            // 
            this.dizinTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizinTemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("dizinTemizleBtn.Image")));
            this.dizinTemizleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dizinTemizleBtn.Location = new System.Drawing.Point(101, 93);
            this.dizinTemizleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dizinTemizleBtn.Name = "dizinTemizleBtn";
            this.dizinTemizleBtn.Size = new System.Drawing.Size(90, 67);
            this.dizinTemizleBtn.TabIndex = 18;
            this.dizinTemizleBtn.Text = "Temizle";
            this.dizinTemizleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dizinTemizleBtn.UseVisualStyleBackColor = true;
            this.dizinTemizleBtn.Click += new System.EventHandler(this.dizinTemizleBtn_Click);
            // 
            // dizinVazgecBtn
            // 
            this.dizinVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizinVazgecBtn.Image = ((System.Drawing.Image)(resources.GetObject("dizinVazgecBtn.Image")));
            this.dizinVazgecBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dizinVazgecBtn.Location = new System.Drawing.Point(193, 93);
            this.dizinVazgecBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dizinVazgecBtn.Name = "dizinVazgecBtn";
            this.dizinVazgecBtn.Size = new System.Drawing.Size(90, 67);
            this.dizinVazgecBtn.TabIndex = 19;
            this.dizinVazgecBtn.Text = "Vazgeç";
            this.dizinVazgecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dizinVazgecBtn.UseVisualStyleBackColor = true;
            this.dizinVazgecBtn.Click += new System.EventHandler(this.dizinVazgecBtn_Click);
            // 
            // dizinGozatBtn
            // 
            this.dizinGozatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizinGozatBtn.Image = ((System.Drawing.Image)(resources.GetObject("dizinGozatBtn.Image")));
            this.dizinGozatBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dizinGozatBtn.Location = new System.Drawing.Point(293, 31);
            this.dizinGozatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dizinGozatBtn.Name = "dizinGozatBtn";
            this.dizinGozatBtn.Size = new System.Drawing.Size(82, 58);
            this.dizinGozatBtn.TabIndex = 20;
            this.dizinGozatBtn.Text = "Gözat";
            this.dizinGozatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dizinGozatBtn.UseVisualStyleBackColor = true;
            this.dizinGozatBtn.Click += new System.EventHandler(this.dizinGozatBtn_Click);
            // 
            // DizinKaydetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 177);
            this.Controls.Add(this.dizinGozatBtn);
            this.Controls.Add(this.dizinVazgecBtn);
            this.Controls.Add(this.dizinTemizleBtn);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.dizinKaydetBtn);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DizinKaydetForm";
            this.Text = "Dizin Kaydetme";
            this.Load += new System.EventHandler(this.DizinKaydetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dizinKaydetBtn;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button dizinTemizleBtn;
        private System.Windows.Forms.Button dizinVazgecBtn;
        private System.Windows.Forms.Button dizinGozatBtn;
    }
}