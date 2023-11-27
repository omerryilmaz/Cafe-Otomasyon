using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DataAccessLayer;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaRezerve : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemYapildi;
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private CafeContext context = new CafeContext();

        public frmMasaRezerve(int masaId)
        {
            _masaId = masaId;
            InitializeComponent();
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            masalar.Islem = txtIslem.Text;
            masalar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
            masalar.KullaniciId = KullaniciAyarlari.kullaniciId;
            masalar.RezerveMi = true;
            masalarDal.Save(context);
            
            islemYapildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}