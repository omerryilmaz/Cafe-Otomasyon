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
using CafeOtomasyonu.Entities.Mapping;
using CafeOtomasyonu.WinForms.AnaMenu;
using DevExpress.XtraBars;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private Entities.Models.Kullanicilar _entity;
        private KullaniciHareketleri kullaniciHareketleri =new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        
        public frmKaydol(Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;

            toggleAktifMi.DataBindings.Add("EditValue", _entity, "AktifMi");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            txtParola.DataBindings.Add("Text", _entity, "Parola");
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                _entity.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _entity))
                {
                    kullanicilarDal.Save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.KullaniciId = model;
                    string aciklama = "Yeni kullanıcı eklendi"; 
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context,kullaniciHareketleri,aciklama);

                    frmAnaMenu frm =new frmAnaMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                Roller rol = new Roller
                                {
                                    KullaniciId = context.Kullanicilar.Max(k=>k.Id),
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
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor!");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKaydol_Load(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void txtCevap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHatirlatmaSorusu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtParolaTekrar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtParola_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}