using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml.Serialization;

namespace Serialization___Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlSerializer serializer = new XmlSerializer(typeof(Car));




        private void buttonSerialization_Click(object sender, EventArgs e)
        {
            Car SelarizeCar = new Car
            {
                marka = cmbMarka.SelectedItem.ToString(),
                model = txtbModel.Text,
                fiyat = Convert.ToInt32(txtbFiyat.Text)
            };

            FileStream fileStreamWhrite = new FileStream("car.xml", FileMode.Create, FileAccess.Write);

            try
            {
                using (fileStreamWhrite)
                {
                    serializer.Serialize(fileStreamWhrite, SelarizeCar);

                    txtbModel.Text = "";
                    cmbMarka.Text = "";
                    txtbFiyat.Text = "";
                    MessageBox.Show("Serializasyon iþlkemi tamamlandý");
                }
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
            }
        }



        private void buttonDeserialization_Click(object sender, EventArgs e)
        {
            FileStream fileStreamRead = new FileStream("car.xml", FileMode.Open, FileAccess.Read);

            try
            {
                using (fileStreamRead)
                {
                    Car deserializeCar = new Car();
                    deserializeCar = (Car)serializer.Deserialize(fileStreamRead);

                    cmbMarka.Text = deserializeCar.marka;
                    txtbModel.Text = deserializeCar.model;
                    txtbFiyat.Text = deserializeCar.fiyat.ToString();
                    MessageBox.Show("Deserializasyon iþlemi yapýldý");
                }
            }

            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
            }
        }

        private void buttonJSONYaz_Click(object sender, EventArgs e)
        {

            try
            {
                Car jsonCar = new Car
                {
                    marka = cmbMarka.SelectedItem.ToString(),
                    model = txtbModel.Text,
                    fiyat = Convert.ToInt32(txtbFiyat.Text)
                };

                JsonSerializer serializer2 = new JsonSerializer();


                using (StreamWriter sw = new StreamWriter(@"C:\Users\furka\source\repos\AcunMedyaEðitim\Ödev\Serialization & Deserialization\jsonSerialazer.json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer2.Serialize(writer, jsonCar);
                }
                cmbMarka.Text = "";
                txtbModel.Text = "";
                txtbFiyat.Text = "";
                MessageBox.Show("JSON verisi baþarýyla dosyaya yazýldý.");
            }
            catch (Exception excp)
            {
                MessageBox.Show("Hata: " + excp.Message);
            }

        }

        private void buttonJSONOku_Click(object sender, EventArgs e)
        {

            try
            {

                using (StreamReader sr = new StreamReader(@"C:\Users\furka\source\repos\AcunMedyaEðitim\Ödev\Serialization & Deserialization\jsonSerialazer.json"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer2 = new JsonSerializer();
                    Car deserializedCar = serializer2.Deserialize<Car>(reader);

                    if (deserializedCar != null)
                    {
                        cmbMarka.Text = deserializedCar.marka;
                        txtbModel.Text = deserializedCar.model;
                        txtbFiyat.Text = deserializedCar.fiyat.ToString();
                    }
                }

                MessageBox.Show("JSON dosyasý baþarýyla okundu.");
            }

            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                MessageBox.Show("JSON okuma sýrasýnda bir hata oluþtu.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
