namespace CafeOtomasyonu.WinForms.Ayarlar
{
    partial class frmYedekleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSunucu = new DevExpress.XtraEditors.TextEdit();
            this.comboVeritabani = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtYol = new DevExpress.XtraEditors.TextEdit();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnYedekAl = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblYuzde = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblDurumu = new DevExpress.XtraEditors.LabelControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVeritabani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Sunucu : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Veritabanı : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 18);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Yol : ";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(97, 51);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSunucu.Properties.Appearance.Options.UseFont = true;
            this.txtSunucu.Size = new System.Drawing.Size(279, 28);
            this.txtSunucu.TabIndex = 11;
            // 
            // comboVeritabani
            // 
            this.comboVeritabani.Location = new System.Drawing.Point(97, 85);
            this.comboVeritabani.Name = "comboVeritabani";
            this.comboVeritabani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboVeritabani.Properties.Appearance.Options.UseFont = true;
            this.comboVeritabani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboVeritabani.Size = new System.Drawing.Size(279, 28);
            this.comboVeritabani.TabIndex = 12;
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(97, 119);
            this.txtYol.Name = "txtYol";
            this.txtYol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtYol.Properties.Appearance.Options.UseFont = true;
            this.txtYol.Size = new System.Drawing.Size(224, 28);
            this.txtYol.TabIndex = 11;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(328, 120);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(48, 29);
            this.btnSec.TabIndex = 13;
            this.btnSec.Text = "...\r\n";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnYedekAl
            // 
            this.btnYedekAl.Location = new System.Drawing.Point(270, 172);
            this.btnYedekAl.Name = "btnYedekAl";
            this.btnYedekAl.Size = new System.Drawing.Size(106, 29);
            this.btnYedekAl.TabIndex = 14;
            this.btnYedekAl.Text = "Yedek Al";
            this.btnYedekAl.Click += new System.EventHandler(this.btnYedekAl_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(97, 172);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(167, 15);
            this.progressBarControl1.TabIndex = 15;
            // 
            // lblYuzde
            // 
            this.lblYuzde.Location = new System.Drawing.Point(245, 193);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(19, 16);
            this.lblYuzde.TabIndex = 16;
            this.lblYuzde.Text = "0%";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(147, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Durumu : ";
            // 
            // lblDurumu
            // 
            this.lblDurumu.Location = new System.Drawing.Point(212, 213);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(45, 16);
            this.lblDurumu.TabIndex = 18;
            this.lblDurumu.Text = "Durumu";
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // frmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 242);
            this.Controls.Add(this.lblDurumu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblYuzde);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnYedekAl);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboVeritabani);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmYedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVeritabani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSunucu;
        private DevExpress.XtraEditors.ComboBoxEdit comboVeritabani;
        private DevExpress.XtraEditors.TextEdit txtYol;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnYedekAl;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblYuzde;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblDurumu;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
    }
}