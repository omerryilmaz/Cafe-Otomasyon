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
using CafeOtomasyonu.Entities.Interfaces;
using CafeOtomasyonu.WinForms.AnaMenu;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private Entities.Models.Kullanicilar _kullanicilar;
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullanicilarDal kullanicilarDal =new KullanicilarDal();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private string _girisyapankullanici;

        public frmKullaniciKaydet(Entities.Models.Kullanicilar kullanicilar,string girisyapankullanici=null)
        {
            InitializeComponent();
            _kullanicilar = kullanicilar;
            _girisyapankullanici = girisyapankullanici;

            toggleAktifMi.DataBindings.Add("EditValue", _kullanicilar, "AktifMi",true);
            txtAdSoyad.DataBindings.Add("Text", _kullanicilar, "AdSoyad",true);
            txtTelefon.DataBindings.Add("Text", _kullanicilar, "Telefon", true);
            txtAdres.DataBindings.Add("Text", _kullanicilar, "Adres", true);
            txtEmail.DataBindings.Add("Text", _kullanicilar, "Email", true);
            txtGorevi.DataBindings.Add("Text", _kullanicilar, "Gorevi", true);
            txtKullaniciAdi.DataBindings.Add("Text", _kullanicilar, "KullaniciAdi", true);
            txtParola.DataBindings.Add("Text", _kullanicilar, "Parola", true);
            txtHatirlatmaSorusu.DataBindings.Add("Text", _kullanicilar, "HatirlatmaSorusu", true);
            txtCevap.DataBindings.Add("Text", _kullanicilar, "Cevap", true);
            txtAciklama.DataBindings.Add("Text", _kullanicilar, "Aciklama", true);
            if (_kullanicilar.Id==0)
            {
                lblBaslik.Text = "Yeni Kullanıcı Ekleme Sayfası";
            }

            else if (_kullanicilar.Id != 0)
            {
                lblBaslik.Text = _kullanicilar.KullaniciAdi + " Bilgileri Sayfası";
            }
        }

        private void frmKullaniciKaydet_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblBaslik.Text == "Yeni Kullanıcı Ekleme Sayfası")
            {
                _kullanicilar.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
                {
                    kullanicilarDal.Save(context);
                    var idMax = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.KullaniciId = idMax;
                    string aciklama = "Yönetici tarafından yeni kullanıcı eklendi";
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);

                    frmAnaMenu frm = new frmAnaMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                Roller rol = new Roller
                                {
                                    KullaniciId = context.Kullanicilar.Max(k => k.Id),
                                    FormName = "frmAnaMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    Visible = false,
                                };
                                context.Rollers.Add(rol);
                                context.SaveChanges();
                            }
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                if (kullanicilarDal.AddOrUpdate(context,_kullanicilar))
                {
                    kullanicilarDal.Save(context);
                    var id = _kullanicilar.Id;
                    kullaniciHareketleri.KullaniciId = id;
                    string aciklama;
                    if (_girisyapankullanici!=null)
                    {
                        
                        aciklama = _kullanicilar.KullaniciAdi + " bilgilerini değiştirdi";
                    }
                    else
                    {
                        aciklama = "Yönetici tarafından " + _kullanicilar.KullaniciAdi + "'nın bilgileri güncellendi."; 
                    }
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    this.Close();
                }
            }
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}