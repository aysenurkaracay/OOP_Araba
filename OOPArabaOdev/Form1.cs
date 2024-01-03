using System.Windows.Forms;

namespace OOPArabaOdev
{
    public partial class Form1 : Form
    {
        private object lstAracListesi;

        public Form1()
        {
            InitializeComponent();
        }

        public enum AracTuru { Binek, Ticari }
        public enum KasaTipi { Kamyonet, Otobüs, Minibüs, Sedan, MPV }
        public enum Marka { FIAT, FORD, VOLKSWAGEN, RENAULT, BMW, HONDA }
        public enum Model { DOBLO, FOCUS, GOLF, PASSAT, MEGANE, CADY, X5, CiViC }
        public enum SanzimanTuru { Duz, Otomatik }
        public enum YakitTuru { Benzinli, Dizel, LPG }



        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblAracRengi.BackColor = colorDialog1.Color;
            }
        }


        private void btnAracResmiEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAracResmi.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                Arac yeniArac = new Arac
                {
                    AracTuru = (global::OOPArabaOdev.AracTuru)(AracTuru)cmbAracTuru.SelectedItem,
                    KasaTipi = (global::OOPArabaOdev.KasaTipi)(KasaTipi)cmbKasaTipi.SelectedItem,
                    Marka = (global::OOPArabaOdev.Marka)(Marka)cmbMarka.SelectedItem,
                    Model = (global::OOPArabaOdev.Model)(Model)cmbModel.SelectedItem,
                    SanzimanTuru = (global::OOPArabaOdev.SanzimanTuru)(SanzimanTuru)cmbSanzimanTuru.SelectedItem,
                    YakitTuru = (global::OOPArabaOdev.YakitTuru)(YakitTuru)cmbYakitTuru.SelectedItem,
                    ModelYili = int.Parse(domainUpDown1.Text),
                    MotorGucu = int.Parse(domainUpDown2.Text)

                };


                // Eklediðimiz bilgileri temizle
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            throw new NotImplementedException();
        }



        private void btnAracResmiEkle_Click_1(object sender, EventArgs e)
        {









        }



        private void btnOlustur_Click_1(object sender, EventArgs e)
        {
            listArac.Items.Clear();
            listArac.Items.Add(cmbAracTuru.SelectedItem + " " + cmbMarka.SelectedItem+" "+cmbModel.SelectedItem+" "+cmbSanzimanTuru+" "+cmbYakitTuru.SelectedIndex+" "+ cmbKasaTipi.SelectedIndex);

        }

        private void btnAracResmiEkle_Click_2(object sender, EventArgs e)
        {
            const string imageFolderPath = @"C:\Users\ASUS\OneDrive\Masaüstü\araba.jfif";

            var fullImagePath = imageFolderPath;
            
            picAracResmi.Image = Image.FromFile(fullImagePath);
            picAracResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(fullImagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    class pictureBoxAracResmi
    {
        internal static string ImageLocation;
    }
}




