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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciRolleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private RollerDal rollerDal = new RollerDal();
        private int _kullaniciid;
        public frmKullaniciRolleri(int kullaniciidid)
        {
            InitializeComponent();
            _kullaniciid = kullaniciidid;
            gridControl1.DataSource = rollerDal.GetAll(context,r=>r.KullaniciId==_kullaniciid);
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            rollerDal.Save(context);
            gridView1.RefreshData();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}