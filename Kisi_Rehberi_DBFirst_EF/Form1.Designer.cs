namespace Kisi_Rehberi_DBFirst_EF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContact = new DataGridView();
            txtAd = new TextBox();
            txtId = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            SuspendLayout();
            // 
            // dgvContact
            // 
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Location = new Point(322, 35);
            dgvContact.Name = "dgvContact";
            dgvContact.RowTemplate.Height = 25;
            dgvContact.Size = new Size(442, 358);
            dgvContact.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(101, 86);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(179, 23);
            txtAd.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 23);
            txtId.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(105, 139);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(179, 23);
            txtSoyad.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(105, 191);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(179, 23);
            txtTelefon.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(101, 252);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(179, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(101, 307);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(179, 23);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(101, 370);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(179, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Kisi ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Kisi Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 10;
            label3.Text = "Kisi Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 194);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 11;
            label4.Text = "Kisi Telefonu:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 438);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtId);
            Controls.Add(txtAd);
            Controls.Add(dgvContact);
            Name = "Form1";
            Text = "Kisi Rehberi";
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContact;
        private TextBox txtAd;
        private TextBox txtId;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}