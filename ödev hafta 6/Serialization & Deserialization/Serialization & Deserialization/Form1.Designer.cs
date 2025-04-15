namespace Serialization___Deserialization
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
            buttonSerialization = new Button();
            buttonDeserialization = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMarka = new ComboBox();
            txtbModel = new TextBox();
            txtbFiyat = new TextBox();
            buttonJSONOku = new Button();
            buttonJSONYaz = new Button();
            SuspendLayout();
            // 
            // buttonSerialization
            // 
            buttonSerialization.Location = new Point(226, 225);
            buttonSerialization.Name = "buttonSerialization";
            buttonSerialization.Size = new Size(84, 23);
            buttonSerialization.TabIndex = 0;
            buttonSerialization.Text = "Serialization";
            buttonSerialization.UseVisualStyleBackColor = true;
            buttonSerialization.Click += buttonSerialization_Click;
            // 
            // buttonDeserialization
            // 
            buttonDeserialization.Location = new Point(323, 225);
            buttonDeserialization.Name = "buttonDeserialization";
            buttonDeserialization.Size = new Size(84, 23);
            buttonDeserialization.TabIndex = 1;
            buttonDeserialization.Text = "Deserialization";
            buttonDeserialization.UseVisualStyleBackColor = true;
            buttonDeserialization.Click += buttonDeserialization_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 93);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 137);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 181);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Fiyat :";
            // 
            // cmbMarka
            // 
            cmbMarka.AutoCompleteCustomSource.AddRange(new string[] { "--Seçiniz", "Acura", "Alfa Romeo", "Audi", "BMW", "Bugatti", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Fiat", "Ford", "Honda", "Hyundai", "Jaguar" });
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Items.AddRange(new object[] { "--Seçiniz", "Acura", "Alfa Romeo", "Audi", "BMW", "Bugatti", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Fiat", "Ford", "Honda", "Hyundai", "Jaguar" });
            cmbMarka.Location = new Point(362, 90);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(156, 23);
            cmbMarka.TabIndex = 5;
            // 
            // txtbModel
            // 
            txtbModel.Location = new Point(362, 134);
            txtbModel.Name = "txtbModel";
            txtbModel.Size = new Size(156, 23);
            txtbModel.TabIndex = 6;
            // 
            // txtbFiyat
            // 
            txtbFiyat.Location = new Point(362, 178);
            txtbFiyat.Name = "txtbFiyat";
            txtbFiyat.Size = new Size(156, 23);
            txtbFiyat.TabIndex = 7;
            // 
            // buttonJSONOku
            // 
            buttonJSONOku.Location = new Point(517, 225);
            buttonJSONOku.Name = "buttonJSONOku";
            buttonJSONOku.Size = new Size(84, 23);
            buttonJSONOku.TabIndex = 9;
            buttonJSONOku.Text = "JSON Oku";
            buttonJSONOku.UseVisualStyleBackColor = true;
            buttonJSONOku.Click += buttonJSONOku_Click;
            // 
            // buttonJSONYaz
            // 
            buttonJSONYaz.Location = new Point(420, 225);
            buttonJSONYaz.Name = "buttonJSONYaz";
            buttonJSONYaz.Size = new Size(84, 23);
            buttonJSONYaz.TabIndex = 10;
            buttonJSONYaz.Text = "JSON Yaz";
            buttonJSONYaz.UseVisualStyleBackColor = true;
            buttonJSONYaz.Click += buttonJSONYaz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonJSONYaz);
            Controls.Add(buttonJSONOku);
            Controls.Add(txtbFiyat);
            Controls.Add(txtbModel);
            Controls.Add(cmbMarka);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeserialization);
            Controls.Add(buttonSerialization);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSerialization;
        private Button buttonDeserialization;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMarka;
        private TextBox txtbModel;
        private TextBox txtbFiyat;
        private Button buttonJSONOku;
        private Button buttonJSONYaz;
    }
}
