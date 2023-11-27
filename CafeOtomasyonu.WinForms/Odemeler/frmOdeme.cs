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
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Odemeler
{
    public partial class frmOdeme : DevExpress.XtraEditors.XtraForm
    {
        private string _satiskodu;
        private string _odemeTuru;
        public OdemeHareketleri odemeHareketleri;
        public bool kaydedildi;
        public decimal _kalan;

        public frmOdeme(string odemeTuru, string satiskodu, decimal kalan)
        {
            InitializeComponent();
            _odemeTuru = odemeTuru;
            _satiskodu = satiskodu;
            _kalan = kalan;
            if (_odemeTuru == "Nakit")
            {
                lblBaslik.Text = "Nakit Ödeme";
            }
            else if (_odemeTuru == "Kredi Kartı")
            {
                lblBaslik.Text = "Kredi Kartı ile Ödeme";
            }

            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (dateEditTarih.EditValue != null)
            {
                odemeHareketleri = new OdemeHareketleri
                {
                    SatisKodu = _satiskodu,
                    OdemeTuru = _odemeTuru,
                    Odenen = calcOdenecekTutar.Value,
                    Aciklama = txtAciklama.Text,
                    Tarih = Convert.ToDateTime(dateEditTarih.Text)
                };
                kaydedildi = true;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Lütfen tarih seçiniz!", "İŞİMPOS");
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            calcOdenecekTutar.Value = _kalan;
        }
    }
}