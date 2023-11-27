using CafeOtomasyonu.Entities.Models;
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

namespace CafeOtomasyonu.WinForms.Ayarlar
{
    public partial class frmGrafik : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        public frmGrafik()
        {
            InitializeComponent();
            var model =context.MasaHareketleri.GroupBy(m=>m.Urun.UrunAdi).
                Select(s=>new
            {
                    UrunAdi=s.Key,
                    Miktar=s.Sum(m=>m.Miktari)
            }).ToList();
            foreach (var item in model)
            {
                chartControl1.Series["Satış Grafiği"].Points.AddPoint(item.UrunAdi, Convert.ToDouble(item.Miktar));
            }
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}