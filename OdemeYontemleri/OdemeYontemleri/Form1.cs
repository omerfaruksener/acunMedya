namespace OdemeYontemleri
{
    public partial class Form1 : Form
    {
        decimal tutar;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("KrediKarti");
            comboBox1.Items.Add("Nakit");
            comboBox1.Items.Add("Havale");
        }
        private void btnOde_Click(object sender, EventArgs e)
        {
            string secilenSinif =(string)comboBox1.SelectedItem;
            if (string.IsNullOrEmpty(secilenSinif))
            {
                MessageBox.Show("L�tfen bir �deme y�ntemi se�in.");
                return;
            }

            try
            {
                tutar = decimal.Parse(txtTutar.Text);
            }
            catch
            {
                MessageBox.Show("Ge�erli bir tutar giriniz.");
                return;
            }

            IOdemeYontemi yontem = null;

            switch (secilenSinif)
            {
                case "KrediKarti":
                    yontem = new KrediKarti();
                    break;
                case "Nakit":
                    yontem = new Eft();
                    break;
                case "Havale":
                    yontem = new Havale();
                    break;
                default:
                    MessageBox.Show("Ge�ersiz se�im.");
                    return;
            }

            string sonuc = yontem.Ode(tutar);
            lblSonuc.Text = sonuc;
        }
    }
}
