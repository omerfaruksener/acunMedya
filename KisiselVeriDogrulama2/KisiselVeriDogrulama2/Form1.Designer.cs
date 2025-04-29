namespace KisiselVeriDogrulama2
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
            btnYazdır = new Button();
            txtBolum = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblbolum = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            lblKisiBilgileri = new Label();
            SuspendLayout();
            // 
            // btnYazdır
            // 
            btnYazdır.Location = new Point(423, 140);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.Size = new Size(113, 61);
            btnYazdır.TabIndex = 0;
            btnYazdır.Text = "Yazdır";
            btnYazdır.UseVisualStyleBackColor = true;
            btnYazdır.Click += btnYazdır_Click;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(193, 227);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(193, 181);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(193, 140);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            // 
            // lblbolum
            // 
            lblbolum.AutoSize = true;
            lblbolum.Location = new Point(86, 230);
            lblbolum.Name = "lblbolum";
            lblbolum.Size = new Size(55, 20);
            lblbolum.TabIndex = 4;
            lblbolum.Text = "Bölüm:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(88, 188);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 5;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(110, 147);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 6;
            lblAd.Text = "Ad:";
            // 
            // lblKisiBilgileri
            // 
            lblKisiBilgileri.AutoSize = true;
            lblKisiBilgileri.Location = new Point(110, 319);
            lblKisiBilgileri.Name = "lblKisiBilgileri";
            lblKisiBilgileri.Size = new Size(94, 20);
            lblKisiBilgileri.TabIndex = 7;
            lblKisiBilgileri.Text = "Kişi Bilgileri: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKisiBilgileri);
            Controls.Add(lblAd);
            Controls.Add(lblSoyad);
            Controls.Add(lblbolum);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtBolum);
            Controls.Add(btnYazdır);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYazdır;
        private TextBox txtBolum;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblbolum;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblKisiBilgileri;
    }
}
