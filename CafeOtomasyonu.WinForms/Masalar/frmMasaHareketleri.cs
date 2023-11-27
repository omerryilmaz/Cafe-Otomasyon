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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        private int? _masaId;
        private int? _menuId;
        private int? _urunId;

        private CafeContext context = new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
        public frmMasaHareketleri(int? masaId=null, int? menuId = null, int? urunId = null)
        {
            InitializeComponent();
            _masaId = masaId;
            _menuId = menuId;
            _urunId = urunId;
            if (_masaId!=null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.MasaId == _masaId);
                return;
            }
            else if (_menuId != null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.Urun.MenuId == _menuId);
                return;
            }
            else if (_urunId != null)
            {
                gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.UrunId == _urunId);
                return;
            }

            gridControl1.DataSource = masaHareketleriDal.GetAll(context);
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}