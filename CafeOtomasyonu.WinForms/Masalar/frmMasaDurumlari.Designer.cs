namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaDurumlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaDurumlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnRezerveEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1079, 31);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnRezerveEt);
            this.groupIslemler.Controls.Add(this.btnMasaAc);
            this.groupIslemler.Controls.Add(this.btnYenile);
            this.groupIslemler.Controls.Add(this.btnSiparisEkle);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 625);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1079, 125);
            this.groupIslemler.TabIndex = 7;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.Enabled = false;
            this.btnRezerveEt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRezerveEt.ImageOptions.SvgImage")));
            this.btnRezerveEt.Location = new System.Drawing.Point(264, 49);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(128, 57);
            this.btnRezerveEt.TabIndex = 1;
            this.btnRezerveEt.Text = "Rezerve Et";
            this.btnRezerveEt.Click += new System.EventHandler(this.btnRezerveEt_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Enabled = false;
            this.btnMasaAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMasaAc.ImageOptions.SvgImage")));
            this.btnMasaAc.Location = new System.Drawing.Point(130, 49);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(128, 57);
            this.btnMasaAc.TabIndex = 1;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(398, 49);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(128, 57);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile-Listele";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Enabled = false;
            this.btnSiparisEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisEkle.ImageOptions.SvgImage")));
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 49);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(112, 57);
            this.btnSiparisEkle.TabIndex = 1;
            this.btnSiparisEkle.Text = "Siparişler";
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(973, 42);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 71);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1079, 594);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // frmMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 750);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMasaDurumlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Durumları";
            this.Load += new System.EventHandler(this.frmMasaDurumlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRezerveEt;
        private DevExpress.XtraEditors.SimpleButton btnMasaAc;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}