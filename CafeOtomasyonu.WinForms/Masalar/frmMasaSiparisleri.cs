using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DataAccessLayer;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;


namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDal musterilerDal = new MusterilerDal();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
        private int? _masaId = null;
        private string _satiskodu = null;
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();
        private Entities.Models.Satislar satislar;
        private SatislarDal satislarDal = new SatislarDal();
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private UrunDal urunDal= new UrunDal();
        private bool _paketSiparis = false;
        private bool yazdir;
        private MenuDal menuDal = new MenuDal();
        frmUrunSec frm = new frmUrunSec();

        public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satiskodu = null, bool paketSiparis=false)
        {
            InitializeComponent();
            _masaId = masaId;
            _satiskodu = satiskodu;
            _paketSiparis=paketSiparis;
            context.MasaHareketleri.Where(m => m.SatisKodu == _satiskodu).Load();
            context.OdemeHareketleri.Where(o => o.SatisKodu == _satiskodu).Load();
            context.Urun.Load();
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();
            lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context);
            if (_masaId != null)
            {
                lblBaslik.Text = masaAdi + " Siparişleri";
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            }
            else if (_masaId==null)
            {
                lblBaslik.Text = "Paket Siparişi veya Veresiye İşlemleri.";
            }

            satislar = satislarDal.GetByFilter(context, s => s.SatisKodu == _satiskodu);
            if (satislar != null)
            {
                lookUpMusteri.EditValue = satislar.MusteriId;
                txtSatisAciklama.Text = satislar.Aciklama;
                dateEditTarih.Text = satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
            }
            HizliSatis();
            

            
        }

        public void HizliSatis()
        {
            var model = menuDal.GetAll(context);
            foreach (var item in model)
            {
                var page = new XtraTabPage();
                page.Text = item.MenuAdi;
                page.Name = item.Id.ToString();
                xtraTabControl1.TabPages.Add(page);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock= DockStyle.Fill;
                page.Controls.Add(panel);
                var modelHizliSatis = urunDal.GetAll(context, u => u.HizliSatis && u.MenuId == item.Id);
                foreach (var urun in modelHizliSatis)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Text = urun.UrunAdi;
                    btn.Name=urun.Id.ToString();
                    btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
                    btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    btn.Size = new Size(100, 100);
                    var image = Image.FromFile(urun.Resim);
                    ımageList1.Images.Add(image);
                    btn.ImageList = ımageList1;
                    btn.Image = ımageList1.Images[0];
                    ımageList1.Images.RemoveAt(0);
                    btn.Appearance.BackColor = Control.DefaultBackColor;
                    btn.BorderStyle = BorderStyles.NoBorder;
                    panel.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var senderbtn = sender as SimpleButton;
            int urunId = Convert.ToInt32(senderbtn.Name);
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            MasaHareketleri entity = new MasaHareketleri
            {
                SatisKodu = _satiskodu,
                UrunId = urunId,
                MasaId = _masaId,
                Miktari = 1,
                IndirimOrani = 0,
                BirimFiyati = Fiyat(model),
                Aciklama = "",
                Tarih = DateTime.Now,
            };
            masaHareketleriDal.AddOrUpdate(context, entity);
        }

        void Hesapla()
        {
            calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value;
            calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplam.Value;
            if (calcToplam.Value != 0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue) /
                                        (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
                                        Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue));
            }
            else if (calcToplam.Value == 0)
            {
                calcIndirimOrani.Value = 0;
            }
        }



        private void repositorySiparisSil1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili sipariş silinecek. Onaylıyor Musunuz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewSiparisler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili ödeme silinecek. Onaylıyor Musunuz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOdemeler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void gridControlSiparisler_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        decimal Fiyat(Urun model)
        {
            decimal birimfiyat = model.BirimFiyat1;
            var modelprogram = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "Birim Fiyatı");
            if (modelprogram!=null)
            {
                switch (modelprogram.AyarAdi)
                {
                    case "BirimFiyat1":
                        birimfiyat=model.BirimFiyat1;
                        break;
                    case "BirimFiyat2":
                        birimfiyat = model.BirimFiyat2;
                        break;
                    case "BirimFiyat3":
                        birimfiyat = model.BirimFiyat3;
                        break;
                }
            }
            return birimfiyat;
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satiskodu,
                    MasaId = _masaId,
                    UrunId = frm.urunModel.Id,
                    Miktari = 1,
                    BirimFiyati = Fiyat(frm.urunModel),
                    IndirimOrani = 0,
                    Aciklama = "",
                    Tarih = DateTime.Now
                };
                masaHareketleriDal.AddOrUpdate(context, entity);
            }
        }

        private void btnMusteriResetle_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }


        private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                if (dateEditTarih.EditValue!=null)
                {
                    if (satislar == null)
                    {
                        satislar = new Entities.Models.Satislar();
                        satislar.SatisKodu = _satiskodu;
                    }

                    satislar.MusteriId = (int?)lookUpMusteri.EditValue;
                    satislar.Aciklama = txtSatisAciklama.Text;
                    satislar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
                    satislar.Kalan = calcKalan.Value;
                    satislar.Odenen = calcOdenen.Value;
                    satislar.Tutar = calcToplam.Value;
                    satislar.IndirimToplami = calcIndirimToplami.Value;
                    satislar.PaketSiparisMi = _paketSiparis;
                    satislarDal.AddOrUpdate(context, satislar);
                    context.SaveChanges();
                    yazdir = true;
                }
                else
                {
                    MessageBox.Show("Lütfen tarih seçiniz!", "İŞİMPOS");
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı.", "İŞİMPOS");
            }
        }



        private void Odemeler_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                var btn = sender as SimpleButton;
                frmOdeme frm = new frmOdeme(btn.Text, _satiskodu, calcKalan.Value);
                frm.ShowDialog();
                if (frm.kaydedildi)
                {
                    if (odemeHareketleriDal.AddOrUpdate(context, frm.odemeHareketleri))
                    {
                        gridViewOdemeler.RefreshData();
                        Hesapla();
                    }
                } 
            }
        }

        private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void gridControlOdemeler_Click(object sender, EventArgs e)
        {

        }

        private void frmMasaSiparisleri_Load(object sender, EventArgs e)
        {

        }

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                if (_masaId != null)
                {
                    if (calcKalan.Value > 0)
                    {
                        if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye borç kaydedilecektir. ",
                                "İŞİMPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.MusteriId == null)
                                {
                                    MessageBox.Show("Önce müşteri seçmelisiniz.", "İŞİMPOS");
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }
                            }
                        }

                    }
                    else if (calcKalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }
                } 
            }
        }

        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durumu = false;
            masalar.Islem = null;
            masalar.KullaniciId = null;
            masalarDal.AddOrUpdate(context, masalar);
            masalarDal.Save(context);
        }

        private void repositoryFiyat1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunId = Convert.ToInt32(gridViewSiparisler.GetFocusedRowCellValue(colUrunId));
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            barFiyat1.Caption = model.BirimFiyat1.ToString();
            barFiyat2.Caption = model.BirimFiyat2.ToString();
            barFiyat3.Caption = model.BirimFiyat3.ToString();

            radialMenu1.ShowPopup(MousePosition);
        }

        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSiparisler.SetFocusedRowCellValue(colBirimFiyati,e.Item.Caption);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            btnKaydet.PerformClick();
            if (yazdir)
            {
                if (_masaId!=null)
                {
                    rptSiparisFisi rpt = new rptSiparisFisi(_satiskodu, masalar.MasaAdi, satislar);
                    frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                    frm.ShowDialog();
                }
                else if (_masaId==null)
                {
                    if (satislar.MusteriId==null)
                    {
                        rptSiparisFisi rpt = new rptSiparisFisi(_satiskodu, _satiskodu, satislar);
                        frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }
                    else if (satislar.MusteriId!=null)
                    {
                        rptSiparisFisi rpt = new rptSiparisFisi(_satiskodu, _satiskodu+" "+satislar.Musteriler.AdiSoyadi, satislar);
                        frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }
                    
                }
            }
        }

        private void calcKalan_EditValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}