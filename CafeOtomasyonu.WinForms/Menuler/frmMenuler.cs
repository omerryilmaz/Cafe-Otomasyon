using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Roles;

namespace CafeOtomasyonu.WinForms.Menuler
{
    public partial class frmMenuler : DevExpress.XtraEditors.XtraForm
    {
       private CafeContext contex = new CafeContext();
        
        public frmMenuler()
        {
            InitializeComponent();
            contex.Menu.Load();
            gridControl1.DataSource = contex.Menu.Local.ToBindingList();
            KullaniciYetki.AdminMi(contex,btnKaydet,btnSil);
            
        }

        private void frmMenuler_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            contex.SaveChanges();
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan menü silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
             gridView1.DeleteSelectedRows();
             contex.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasaHareketleri_Click(object sender, EventArgs e)
        {
            int menuId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasaHareketleri frm = new frmMasaHareketleri(menuId: menuId);
            frm.ShowDialog();
        }
    }
}