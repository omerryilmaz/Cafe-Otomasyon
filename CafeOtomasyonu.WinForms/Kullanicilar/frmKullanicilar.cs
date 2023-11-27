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
using CafeOtomasyonu.WinForms.Roles;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context =new CafeContext();
        private KullanicilarDal kullanicilarDal =new KullanicilarDal();
        public frmKullanicilar()
        {
            InitializeComponent();
            Listele();
            KullaniciYetki.AdminMi(context,btnKaydet,btnGuncelle,btnYeni,btnRoller,gridControl1);
        }

        private void Listele()
        {
            gridControl1.DataSource = kullanicilarDal.GetAll(context);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmKullaniciKaydet frm = new frmKullaniciKaydet(new Entities.Models.Kullanicilar());
            frm.ShowDialog();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var model = kullanicilarDal.GetByFilter(context, k => k.Id == id);
            frmKullaniciKaydet frm = new frmKullaniciKaydet(model);
            frm.ShowDialog();
            Listele();
        }

        private void btnRoller_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmKullaniciRolleri frm = new frmKullaniciRolleri(id);
            frm.ShowDialog();
        }
    }
}