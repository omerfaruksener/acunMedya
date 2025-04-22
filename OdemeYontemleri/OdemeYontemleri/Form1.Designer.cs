namespace OdemeYontemleri
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
            comboBox1 = new ComboBox();
            lblOdemeYontemi = new Label();
            btnOde = new Button();
            lblTutar = new Label();
            txtTutar = new TextBox();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(322, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // lblOdemeYontemi
            // 
            lblOdemeYontemi.AutoSize = true;
            lblOdemeYontemi.Location = new Point(99, 79);
            lblOdemeYontemi.Name = "lblOdemeYontemi";
            lblOdemeYontemi.Size = new Size(173, 20);
            lblOdemeYontemi.TabIndex = 1;
            lblOdemeYontemi.Text = "Ödeme Yöntemi Seçiniz :";
            // 
            // btnOde
            // 
            btnOde.Location = new Point(578, 65);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(99, 34);
            btnOde.TabIndex = 2;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(159, 146);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(50, 20);
            lblTutar.TabIndex = 3;
            lblTutar.Text = "Tutar :";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(322, 139);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 4;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(566, 240);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(txtTutar);
            Controls.Add(lblTutar);
            Controls.Add(btnOde);
            Controls.Add(lblOdemeYontemi);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblOdemeYontemi;
        private Button btnOde;
        private Label lblTutar;
        private TextBox txtTutar;
        private Label lblSonuc;
    }
}
