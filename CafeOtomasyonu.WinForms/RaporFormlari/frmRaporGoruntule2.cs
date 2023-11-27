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
using DevExpress.XtraReports.UI;

namespace CafeOtomasyonu.WinForms.RaporFormlari
{
    public partial class frmRaporGoruntule2 : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGoruntule2(XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource= report;
        }
    }
}