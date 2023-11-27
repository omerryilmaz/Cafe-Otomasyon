using CafeOtomasyonu.Entities.Models;
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

namespace CafeOtomasyonu.WinForms.Musteriler
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {

        private CafeContext contex = new CafeContext();
        public frmMusteriler()
        {
            InitializeComponent();
            contex.Musteriler.Load();
            gridControl1.DataSource = contex.Musteriler.Local.ToBindingList();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            contex.SaveChanges();
            gridView1.RefreshData();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan müşteri silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                contex.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}