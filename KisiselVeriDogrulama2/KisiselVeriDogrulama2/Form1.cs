using System.Xml.Linq;

namespace KisiselVeriDogrulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazd�r_Click(object sender, EventArgs e)
        {
            KisiselVeriler person1 = new KisiselVeriler
            {
                Department = txtBolum.Text,
                name = txtAd.Text,
                lastName = txtSoyad.Text,
            };

            lblKisiBilgileri.Text = $"Ad� : {txtAd.Text} Soyad�: {txtSoyad.Text} B�l�m�: {txtBolum.Text}";

            if (ZorunlulukKontrol�.dogrula(person1, out List<string> hatalar))
            {
                MessageBox.Show("Kay�t ba�ar�l�!");
            }
            else
            {
                MessageBox.Show("Hatalar:\n" + string.Join("\n", hatalar));
            }

        }
    }
}
