namespace ADO.NET
{
    partial class Form1
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
            this.btnDByeKaydet = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDByeKaydet
            // 
            this.btnDByeKaydet.Location = new System.Drawing.Point(360, 465);
            this.btnDByeKaydet.Name = "btnDByeKaydet";
            this.btnDByeKaydet.Size = new System.Drawing.Size(141, 59);
            this.btnDByeKaydet.TabIndex = 13;
            this.btnDByeKaydet.Text = "DB\'YE KAYDET";
            this.btnDByeKaydet.UseVisualStyleBackColor = true;
            this.btnDByeKaydet.Click += new System.EventHandler(this.btnDByeKaydet_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(360, 411);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(141, 40);
            this.btnPersonelEkle.TabIndex = 12;
            this.btnPersonelEkle.Text = "PERSONEL EKLE";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(173, 463);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(140, 22);
            this.txtPersonelSoyadi.TabIndex = 11;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(173, 419);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(140, 22);
            this.txtPersonelAdi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personel Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel Adı:";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(13, 13);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.Size = new System.Drawing.Size(488, 378);
            this.dgvListe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 576);
            this.Controls.Add(this.btnDByeKaydet);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDByeKaydet;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListe;
    }
}

