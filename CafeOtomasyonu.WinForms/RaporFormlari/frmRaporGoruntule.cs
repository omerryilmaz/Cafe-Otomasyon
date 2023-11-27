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
    public partial class frmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGoruntule(XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}