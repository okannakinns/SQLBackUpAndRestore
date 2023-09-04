namespace SQLbackup2
{
    partial class FrmLisans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisans));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLisansAnahtari = new System.Windows.Forms.TextBox();
            this.LisansVazgecBtn = new System.Windows.Forms.Button();
            this.LisansTemizleBtn = new System.Windows.Forms.Button();
            this.LisansKaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lisans Anahtarı:";
            // 
            // txtLisansAnahtari
            // 
            this.txtLisansAnahtari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLisansAnahtari.Location = new System.Drawing.Point(135, 29);
            this.txtLisansAnahtari.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisansAnahtari.Name = "txtLisansAnahtari";
            this.txtLisansAnahtari.Size = new System.Drawing.Size(359, 29);
            this.txtLisansAnahtari.TabIndex = 28;
            // 
            // LisansVazgecBtn
            // 
            this.LisansVazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisansVazgecBtn.Image = ((System.Drawing.Image)(resources.GetObject("LisansVazgecBtn.Image")));
            this.LisansVazgecBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LisansVazgecBtn.Location = new System.Drawing.Point(376, 75);
            this.LisansVazgecBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LisansVazgecBtn.Name = "LisansVazgecBtn";
            this.LisansVazgecBtn.Size = new System.Drawing.Size(90, 64);
            this.LisansVazgecBtn.TabIndex = 27;
            this.LisansVazgecBtn.Text = "Vazgeç";
            this.LisansVazgecBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LisansVazgecBtn.UseVisualStyleBackColor = true;
            this.LisansVazgecBtn.Click += new System.EventHandler(this.LisansVazgecBtn_Click);
            // 
            // LisansTemizleBtn
            // 
            this.LisansTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisansTemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("LisansTemizleBtn.Image")));
            this.LisansTemizleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LisansTemizleBtn.Location = new System.Drawing.Point(272, 76);
            this.LisansTemizleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LisansTemizleBtn.Name = "LisansTemizleBtn";
            this.LisansTemizleBtn.Size = new System.Drawing.Size(90, 64);
            this.LisansTemizleBtn.TabIndex = 26;
            this.LisansTemizleBtn.Text = "Temizle";
            this.LisansTemizleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LisansTemizleBtn.UseVisualStyleBackColor = true;
            this.LisansTemizleBtn.Click += new System.EventHandler(this.LisansTemizleBtn_Click);
            // 
            // LisansKaydetBtn
            // 
            this.LisansKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LisansKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("LisansKaydetBtn.Image")));
            this.LisansKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LisansKaydetBtn.Location = new System.Drawing.Point(168, 76);
            this.LisansKaydetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LisansKaydetBtn.Name = "LisansKaydetBtn";
            this.LisansKaydetBtn.Size = new System.Drawing.Size(90, 64);
            this.LisansKaydetBtn.TabIndex = 25;
            this.LisansKaydetBtn.Text = "Kaydet";
            this.LisansKaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LisansKaydetBtn.UseVisualStyleBackColor = true;
            this.LisansKaydetBtn.Click += new System.EventHandler(this.LisansKaydetBtn_Click);
            // 
            // FrmLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLisansAnahtari);
            this.Controls.Add(this.LisansVazgecBtn);
            this.Controls.Add(this.LisansTemizleBtn);
            this.Controls.Add(this.LisansKaydetBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans İşlemleri";
            this.Load += new System.EventHandler(this.FrmLisans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLisansAnahtari;
        private System.Windows.Forms.Button LisansVazgecBtn;
        private System.Windows.Forms.Button LisansTemizleBtn;
        private System.Windows.Forms.Button LisansKaydetBtn;
    }
}