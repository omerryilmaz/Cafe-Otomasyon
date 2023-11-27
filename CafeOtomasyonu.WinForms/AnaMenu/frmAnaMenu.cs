using DevExpress.XtraBars;
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
using CafeOtomasyonu.WinForms.Kullanicilar;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Menuler;
using CafeOtomasyonu.WinForms.Musteriler;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Roles;
using CafeOtomasyonu.WinForms.Satislar;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.XtraEditors;
using CafeOtomasyonu.Entities.DataAccessLayer;
using CafeOtomasyonu.Entities.Tools;
using CafeOtomasyonu.WinForms.Ayarlar;
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        public frmAnaMenu()
        {
            InitializeComponent();
            ConnectionTools.VeriDoldur(context);

            if (!context.Kullanicilar.Any(k => k.KullaniciAdi == "Admin"))
            {
                Entities.Models.Kullanicilar model = new Entities.Models.Kullanicilar()
                {
                    AdSoyad = "Deneme Ad Soyad",
                    Telefon = "554959",
                    Adres = "Deneme Adres",
                    Email = "deneme@deneme.com",
                    Gorevi = "Deneme Gorev",
                    KullaniciAdi = "Admin",
                    Parola = "123",
                    HatirlatmaSorusu = "1",
                    Cevap = "1",
                    KayitTarihi = DateTime.Now,
                    IsAdmin = true,

                };
                context.Kullanicilar.Add(model);
                context.SaveChanges();

                foreach (var item in ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        var btn=item as BarButtonItem;
                        if (btn.Caption!="")
                        {
                            Roller rol = new Roller
                            {
                                KullaniciId = 1,
                                FormName = "frmAnaMenu",
                                ControlCaption = btn.Caption,
                                ControlName = btn.Name,
                                Visible = true,
                            };
                            context.Rollers.Add(rol);
                            context.SaveChanges();
                        }
                    }
                }
            }
            
        }

        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            frmKullaniciGirisi frm = new frmKullaniciGirisi();
            frm.ShowDialog();
            KullaniciYetki.YetkileriGetir(context, ribbon);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasalar();
            FormGetir(frm);
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmUrunler();
            FormGetir(frm);
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullanicilar frm=new frmKullanicilar();
            FormGetir(frm);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasaDurumlari();
            FormGetir(frm);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMusteriler();
            FormGetir(frm);
        }

        private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSatislar();
            FormGetir(frm);
        }

        private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmOdemeHareketleri();
            FormGetir(frm);
        }

        private void btnPaketSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string satiskodu = model.SatisTanimi + model.Sayi;
                model.Sayi++;
                context.SaveChanges();
                XtraForm frm = new frmMasaSiparisleri(satiskodu: satiskodu, paketSiparis: true);
                frm.ShowDialog();
            }
        }

        private void btnMasaHareketleriRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptMasaHareketleri report = new rptMasaHareketleri();
            frmRaporGoruntule2 frm = new frmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnOzelRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOzelRapor frm = new frmOzelRapor();
            frm.ShowDialog();
        }

        private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmMasaHareketleri();
            frm.ShowDialog();
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDashboard();
            FormGetir(frm);
        }

        private void btnBilgilerim_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model = kullanicilarDal.GetByFilter(context, k => k.Id == KullaniciAyarlari.kullaniciId);
            frmKullaniciKaydet frm = new frmKullaniciKaydet(model,"dfd");
            frm.ShowDialog();
        }

        private void btnAyarlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }

        private void btnYedekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmYedekleme frm = new frmYedekleme();
            frm.ShowDialog();
        }

        private void btnGrafik_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGrafik frm = new frmGrafik();
            FormGetir(frm);
        }
    }
}