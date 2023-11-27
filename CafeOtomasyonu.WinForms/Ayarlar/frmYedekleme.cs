using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace CafeOtomasyonu.WinForms.Ayarlar
{
    public partial class frmYedekleme : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context =new CafeContext();
        public frmYedekleme()
        {
            InitializeComponent();
            Server sunucu = new Server();
            var model = context.Database.SqlQuery<Database>("Select * from sys.databases").ToList();
            foreach (var item in model)
            {
                comboVeritabani.Properties.Items.Add(item.Name);
            }

            comboVeritabani.EditValue = "Cafe";

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)|*.bak";
            xtraSaveFileDialog1.Title = "Yedeklenecek Dosyalar";
            if (xtraSaveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtYol.Text= xtraSaveFileDialog1.FileName;
            }
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            try
            {
                if (System.IO.File.Exists(txtYol.Text))
                {
                    File.Delete(txtYol.Text);
                }
                Server dbServer = new Server(new ServerConnection(txtSunucu.Text));
                Backup dbBackup = new Backup();
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = comboVeritabani.Text;
                dbBackup.Devices.AddDevice(txtYol.Text,DeviceType.File);
                dbBackup.Initialize = false;
                dbBackup.SqlBackup(dbServer);



            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata\n" + exception.Message);
            }
        }
    }
}