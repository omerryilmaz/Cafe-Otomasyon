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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal = new MasalarDal();
        public frmMasalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masalarDal.MasalariListele(context);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmMasaKaydet frm = new frmMasaKaydet(new Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar =masalarDal.GetByFilter(context, m => m.Id == seciliId);
            frmMasaKaydet frm = new frmMasaKaydet(masalar);
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masalarDal.Delete(context, m => m.Id == seciliId);
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.Durumu)
                {
                    masalar.Durumu = false;

                }
                else if (!masalar.Durumu)
                {
                    masalar.Durumu = true;
                } 
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnRezerveDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.RezerveMi)
                {
                    masalar.RezerveMi = false;

                }
                else if (!masalar.RezerveMi)
                {
                    masalar.RezerveMi = true;
                }
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasaHareketleri_Click(object sender, EventArgs e)
        {
            int masaId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasaHareketleri frm=new frmMasaHareketleri(masaId:masaId);
            frm.ShowDialog();
        }
    }
}