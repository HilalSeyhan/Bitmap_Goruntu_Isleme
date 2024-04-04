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
    public partial class formParlaklik : DevExpress.XtraEditors.XtraForm
    {
        public formParlaklik()
        {
            InitializeComponent();
        }

        private void formParlaklik_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
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
                label1.Visible = true;
                textBox1.Visible = true;
                button2.Visible = true;
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int R = 0, G = 0, B = 0;
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.
                int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
                int parlaklikDegeri=Convert.ToInt32(textBox1.Text);
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    j = 0;
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        //Rengini 50 değeri ile açacak.
                        R = OkunanRenk.R + parlaklikDegeri;
                        G = OkunanRenk.G + parlaklikDegeri;
                        B = OkunanRenk.B + parlaklikDegeri;
                        //Renkler 255 geçtiyse son sınır olan 255 alınacak.
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(i, j, DonusenRenk);
                        j++;
                    }
                    i++;

                    pictureBox2.Image = CikisResmi;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verileri kontrol edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}