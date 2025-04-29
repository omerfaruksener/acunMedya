using System.Xml.Linq;

namespace KisiselVeriDogrulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdýr_Click(object sender, EventArgs e)
        {
            KisiselVeriler person1 = new KisiselVeriler
            {
                Department = txtBolum.Text,
                name = txtAd.Text,
                lastName = txtSoyad.Text,
            };

            lblKisiBilgileri.Text = $"Adý : {txtAd.Text} Soyadý: {txtSoyad.Text} Bölümü: {txtBolum.Text}";

            if (ZorunlulukKontrolü.dogrula(person1, out List<string> hatalar))
            {
                MessageBox.Show("Kayýt baþarýlý!");
            }
            else
            {
                MessageBox.Show("Hatalar:\n" + string.Join("\n", hatalar));
            }

        }
    }
}
