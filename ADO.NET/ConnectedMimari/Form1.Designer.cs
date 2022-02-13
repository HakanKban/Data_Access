namespace ConnectedMimari
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbGuncelle = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStokGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunAdiGuncelle = new System.Windows.Forms.TextBox();
            this.gbEkle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtFiyatEkle = new System.Windows.Forms.TextBox();
            this.txtUrunAdiEkle = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.gbGuncelle.SuspendLayout();
            this.gbEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 407);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 213);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Fiyatı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok";
            // 
            // gbGuncelle
            // 
            this.gbGuncelle.Controls.Add(this.label6);
            this.gbGuncelle.Controls.Add(this.txtStokGuncelle);
            this.gbGuncelle.Controls.Add(this.label5);
            this.gbGuncelle.Controls.Add(this.btnGuncelle);
            this.gbGuncelle.Controls.Add(this.label4);
            this.gbGuncelle.Controls.Add(this.txtFiyatGuncelle);
            this.gbGuncelle.Controls.Add(this.txtUrunAdiGuncelle);
            this.gbGuncelle.Location = new System.Drawing.Point(442, 20);
            this.gbGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.gbGuncelle.Name = "gbGuncelle";
            this.gbGuncelle.Padding = new System.Windows.Forms.Padding(4);
            this.gbGuncelle.Size = new System.Drawing.Size(373, 326);
            this.gbGuncelle.TabIndex = 9;
            this.gbGuncelle.TabStop = false;
            this.gbGuncelle.Text = "GÜNCELLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stok:";
            // 
            // txtStokGuncelle
            // 
            this.txtStokGuncelle.Location = new System.Drawing.Point(108, 138);
            this.txtStokGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtStokGuncelle.Name = "txtStokGuncelle";
            this.txtStokGuncelle.Size = new System.Drawing.Size(256, 22);
            this.txtStokGuncelle.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fiyat:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(201, 271);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(164, 28);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Adı:";
            // 
            // txtFiyatGuncelle
            // 
            this.txtFiyatGuncelle.Location = new System.Drawing.Point(108, 89);
            this.txtFiyatGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            this.txtFiyatGuncelle.Size = new System.Drawing.Size(256, 22);
            this.txtFiyatGuncelle.TabIndex = 0;
            // 
            // txtUrunAdiGuncelle
            // 
            this.txtUrunAdiGuncelle.Location = new System.Drawing.Point(108, 43);
            this.txtUrunAdiGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdiGuncelle.Name = "txtUrunAdiGuncelle";
            this.txtUrunAdiGuncelle.Size = new System.Drawing.Size(256, 22);
            this.txtUrunAdiGuncelle.TabIndex = 0;
            // 
            // gbEkle
            // 
            this.gbEkle.Controls.Add(this.label3);
            this.gbEkle.Controls.Add(this.label2);
            this.gbEkle.Controls.Add(this.label1);
            this.gbEkle.Controls.Add(this.txtStokEkle);
            this.gbEkle.Controls.Add(this.btnEkle);
            this.gbEkle.Controls.Add(this.txtFiyatEkle);
            this.gbEkle.Controls.Add(this.txtUrunAdiEkle);
            this.gbEkle.Location = new System.Drawing.Point(26, 20);
            this.gbEkle.Margin = new System.Windows.Forms.Padding(4);
            this.gbEkle.Name = "gbEkle";
            this.gbEkle.Padding = new System.Windows.Forms.Padding(4);
            this.gbEkle.Size = new System.Drawing.Size(373, 326);
            this.gbEkle.TabIndex = 10;
            this.gbEkle.TabStop = false;
            this.gbEkle.Text = "EKLE";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtStokEkle
            // 
            this.txtStokEkle.Location = new System.Drawing.Point(108, 138);
            this.txtStokEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtStokEkle.Name = "txtStokEkle";
            this.txtStokEkle.Size = new System.Drawing.Size(256, 22);
            this.txtStokEkle.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(201, 271);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 28);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtFiyatEkle
            // 
            this.txtFiyatEkle.Location = new System.Drawing.Point(108, 89);
            this.txtFiyatEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyatEkle.Name = "txtFiyatEkle";
            this.txtFiyatEkle.Size = new System.Drawing.Size(256, 22);
            this.txtFiyatEkle.TabIndex = 0;
            // 
            // txtUrunAdiEkle
            // 
            this.txtUrunAdiEkle.Location = new System.Drawing.Point(108, 43);
            this.txtUrunAdiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdiEkle.Name = "txtUrunAdiEkle";
            this.txtUrunAdiEkle.Size = new System.Drawing.Size(256, 22);
            this.txtUrunAdiEkle.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(235, 372);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(164, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(29, 372);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(164, 28);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(651, 627);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(164, 28);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(29, 631);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(239, 22);
            this.txtAra.TabIndex = 5;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 679);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbGuncelle);
            this.Controls.Add(this.gbEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGuncelle.ResumeLayout(false);
            this.gbGuncelle.PerformLayout();
            this.gbEkle.ResumeLayout(false);
            this.gbEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gbGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStokGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.TextBox txtUrunAdiGuncelle;
        private System.Windows.Forms.GroupBox gbEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtFiyatEkle;
        private System.Windows.Forms.TextBox txtUrunAdiEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
    }
}

