namespace SQLbackup2
{
    partial class FrmTekrarKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTekrarKaydet));
            this.TekrarVazgecBtn = new System.Windows.Forms.Button();
            this.TekrarTemizleBtn = new System.Windows.Forms.Button();
            this.TekrarKaydetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TekrarNumericUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TekrarNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TekrarVazgecBtn
            // 
            this.TekrarVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarVazgecBtn.Location = new System.Drawing.Point(341, 98);
            this.TekrarVazgecBtn.Name = "TekrarVazgecBtn";
            this.TekrarVazgecBtn.Size = new System.Drawing.Size(117, 41);
            this.TekrarVazgecBtn.TabIndex = 11;
            this.TekrarVazgecBtn.Text = "Vazgeç";
            this.TekrarVazgecBtn.UseVisualStyleBackColor = true;
            this.TekrarVazgecBtn.Click += new System.EventHandler(this.TekrarVazgecBtn_Click);
            // 
            // TekrarTemizleBtn
            // 
            this.TekrarTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarTemizleBtn.Location = new System.Drawing.Point(217, 98);
            this.TekrarTemizleBtn.Name = "TekrarTemizleBtn";
            this.TekrarTemizleBtn.Size = new System.Drawing.Size(117, 41);
            this.TekrarTemizleBtn.TabIndex = 10;
            this.TekrarTemizleBtn.Text = "Temizle";
            this.TekrarTemizleBtn.UseVisualStyleBackColor = true;
            this.TekrarTemizleBtn.Click += new System.EventHandler(this.TekrarTemizleBtn_Click);
            // 
            // TekrarKaydetBtn
            // 
            this.TekrarKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarKaydetBtn.Location = new System.Drawing.Point(94, 98);
            this.TekrarKaydetBtn.Name = "TekrarKaydetBtn";
            this.TekrarKaydetBtn.Size = new System.Drawing.Size(117, 41);
            this.TekrarKaydetBtn.TabIndex = 9;
            this.TekrarKaydetBtn.Text = "Kaydet";
            this.TekrarKaydetBtn.UseVisualStyleBackColor = true;
            this.TekrarKaydetBtn.Click += new System.EventHandler(this.TekrarKaydetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tekrar:";
            // 
            // TekrarNumericUD
            // 
            this.TekrarNumericUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TekrarNumericUD.Location = new System.Drawing.Point(184, 43);
            this.TekrarNumericUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.TekrarNumericUD.Name = "TekrarNumericUD";
            this.TekrarNumericUD.Size = new System.Drawing.Size(274, 30);
            this.TekrarNumericUD.TabIndex = 13;
            // 
            // TekrarKaydetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 162);
            this.Controls.Add(this.TekrarNumericUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TekrarVazgecBtn);
            this.Controls.Add(this.TekrarTemizleBtn);
            this.Controls.Add(this.TekrarKaydetBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TekrarKaydetForm";
            this.Text = "Tekrar Kaydetme";
            this.Load += new System.EventHandler(this.TekrarKaydetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TekrarNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TekrarVazgecBtn;
        private System.Windows.Forms.Button TekrarTemizleBtn;
        private System.Windows.Forms.Button TekrarKaydetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TekrarNumericUD;
    }
}