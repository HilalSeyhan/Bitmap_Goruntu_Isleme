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
    public partial class formMenu : DevExpress.XtraEditors.XtraForm
    {
        public formMenu()
        {
            InitializeComponent();
        }

        formNegatif frmNegatif;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNegatif == null || frmNegatif.IsDisposed)
            {
                frmNegatif = new formNegatif();
                frmNegatif.MdiParent = this;
                frmNegatif.Show();
            }
        }

        formGri frmGri;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGri == null || frmGri.IsDisposed)
            {
                frmGri = new formGri();
                frmGri.MdiParent = this;
                frmGri.Show();
            }
        }

        formEsikleme frmEsikleme;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmEsikleme == null || frmEsikleme.IsDisposed)
            {
                frmEsikleme = new formEsikleme();
                frmEsikleme.MdiParent = this;
                frmEsikleme.Show();
            }
        }

        formParlaklik frmParlaklik;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmParlaklik == null || frmParlaklik.IsDisposed)
            {
                frmParlaklik = new formParlaklik();
                frmParlaklik.MdiParent = this;
                frmParlaklik.Show();
            }
        }

        formKarsitlik frmKarsitlik;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKarsitlik == null || frmKarsitlik.IsDisposed)
            {
                frmKarsitlik = new formKarsitlik();
                frmKarsitlik.MdiParent = this;
                frmKarsitlik.Show();
            }
        }

        formKontrast frmkontrast;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkontrast == null || frmkontrast.IsDisposed)
            {
                frmkontrast = new formKontrast();
                frmkontrast.MdiParent = this;
                frmkontrast.Show();
            }
        }

        formBinary frmBinary;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBinary == null || frmBinary.IsDisposed)
            {
                frmBinary = new formBinary();
                frmBinary.MdiParent = this;
                frmBinary.Show();
            }
        }

        formDondurme frmDondurme;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDondurme == null || frmDondurme.IsDisposed)
            {
                frmDondurme = new formDondurme();
                frmDondurme.MdiParent = this;
                frmDondurme.Show();
            }
        }

        formKaydirma frmKaydirma;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKaydirma == null || frmKaydirma.IsDisposed)
            {
                frmKaydirma = new formKaydirma();
                frmKaydirma.MdiParent = this;
                frmKaydirma.Show();
            }
        }

        formTersCevirme frmTersCevirme;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTersCevirme == null || frmTersCevirme.IsDisposed)
            {
                frmTersCevirme = new formTersCevirme();
                frmTersCevirme.MdiParent = this;
                frmTersCevirme.Show();
            }
        }

        formYansima frmYansima;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYansima == null || frmYansima.IsDisposed)
            {
                frmYansima = new formYansima();
                frmYansima.MdiParent = this;
                frmYansima.Show();
            }
        }

        formKucultme frmKucultme;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKucultme == null || frmKucultme.IsDisposed)
            {
                frmKucultme = new formKucultme();
                frmKucultme.MdiParent = this;
                frmKucultme.Show();
            }
        }

        formMean frmMean;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMean == null || frmMean.IsDisposed)
            {
                frmMean = new formMean();
                frmMean.MdiParent = this;
                frmMean.Show();
            }
        }

        formMedian frmMedian;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMedian == null || frmMedian.IsDisposed)
            {
                frmMedian = new formMedian();
                frmMedian.MdiParent = this;
                frmMedian.Show();
            }
        }
    }
}