using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace goruntu_islemeProje
{
    public partial class formBinary : DevExpress.XtraEditors.XtraForm
    {
        public formBinary()
        {
            InitializeComponent();
        }

        private void formBinary_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ResminYolu);
                button2.Visible = true;
            }
            catch
            {
            }
        }

        private Bitmap griYap(Bitmap image)
        {
            Color OkunanRenk, DonusenRenk;

            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini   oluşturuyor.Boyutları giriş resmi ile aynı olur.
            int GriDeger = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    double R = OkunanRenk.R;
                    double G = OkunanRenk.G;
                    double B = OkunanRenk.B;
                    GriDeger = Convert.ToInt16((R + G + B) / 3);

                    //GriDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    DonusenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }

        private Bitmap binaryYap(Bitmap image)
        {
            Bitmap gri = griYap(image);
            int temp = 0;
            int esik = 100;
            Color renk;
            for (int i = 0; i < gri.Height - 1; i++)
            {
                for (int j = 0; j < gri.Width - 1; j++)
                {
                    temp = gri.GetPixel(j, i).R;
                    if (temp < esik)
                    {
                        renk = Color.FromArgb(0, 0, 0);
                        gri.SetPixel(j, i, renk);
                    }
                    else
                    {
                        renk = Color.FromArgb(255, 255, 255);
                        gri.SetPixel(j, i, renk);
                    }
                }
            }
            return gri;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Bitmap binary = binaryYap(image);
                pictureBox2.Image = binary;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verileri kontrol edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}