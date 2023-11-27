using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using CafeOtomasyonu.Entities.DataAccessLayer;
using CafeOtomasyonu.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;

namespace CafeOtomasyonu.WinForms.RaporDosyalari
{
    public partial class rptSiparisFisi : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context =new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();

        public rptSiparisFisi(string satisKodu,string bilgi, Entities.Models.Satislar satislar=null)
        {
            InitializeComponent();
            ObjectDataSource source =new ObjectDataSource();
            xrLabelBilgi.Text = bilgi;
            source.DataSource = masaHareketleriDal.GetAll(context, m => m.SatisKodu == satisKodu);
            this.DataSource = source;
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
            xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
            xrTableIndırım.DataBindings.Add("Text", DataSource, "IndirimTutari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
            xrLabelKalan.Text=satislar.Kalan.ToString("C2");
            xrLabelOdenen.Text=satislar.Odenen.ToString("C2");
           
            

        }

    }
}
