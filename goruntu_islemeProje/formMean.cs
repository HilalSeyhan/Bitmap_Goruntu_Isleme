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
    public partial class formMean : DevExpress.XtraEditors.XtraForm
    {
        public formMean()
        {
            InitializeComponent();
        }

        private void formMean_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
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
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
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
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int secilenSablon = 3;
                if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    if (radioButton1.Checked) secilenSablon = 3;
                    if (radioButton2.Checked) secilenSablon = 5;
                    if (radioButton3.Checked) secilenSablon = 7;
                    int SablonBoyutu = secilenSablon; //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
                    int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                    for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                    {
                        for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                        {
                            toplamR = 0;
                            toplamG = 0;
                            toplamB = 0;
                            for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                            {
                                for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                {
                                    OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                    toplamR = toplamR + OkunanRenk.R;
                                    toplamG = toplamG + OkunanRenk.G;
                                    toplamB = toplamB + OkunanRenk.B;
                                }
                            }
                            ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                            ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                            ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                            CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                }
                else MessageBox.Show("Lütfen şablon seçimi yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen verileri kontrol edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}