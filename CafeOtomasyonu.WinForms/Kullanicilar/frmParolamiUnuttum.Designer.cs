namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    partial class frmParolamiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParolamiUnuttum));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtCevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtHatirlatmaSorusu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtYeniParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtYeniParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdiEmail = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHatirlatmaSorusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiEmail.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(469, 31);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Parolamı Unuttum";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 189);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(469, 85);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(5, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 38);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(352, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(112, 38);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl18.Appearance.Options.UseBorderColor = true;
            this.labelControl18.Appearance.Options.UseTextOptions = true;
            this.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl18.Location = new System.Drawing.Point(0, 103);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(160, 27);
            this.labelControl18.TabIndex = 21;
            this.labelControl18.Text = "Cevap :";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl17.Appearance.Options.UseBorderColor = true;
            this.labelControl17.Appearance.Options.UseTextOptions = true;
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl17.Location = new System.Drawing.Point(0, 75);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(160, 27);
            this.labelControl17.TabIndex = 22;
            this.labelControl17.Text = "Hatırlatma Sorusu :";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(190, 106);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(263, 22);
            this.txtCevap.TabIndex = 16;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl16.Appearance.Options.UseBorderColor = true;
            this.labelControl16.Appearance.Options.UseTextOptions = true;
            this.labelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl16.Location = new System.Drawing.Point(0, 159);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(160, 27);
            this.labelControl16.TabIndex = 23;
            this.labelControl16.Text = "Parola Tekrar :";
            // 
            // txtHatirlatmaSorusu
            // 
            this.txtHatirlatmaSorusu.Location = new System.Drawing.Point(190, 78);
            this.txtHatirlatmaSorusu.Name = "txtHatirlatmaSorusu";
            this.txtHatirlatmaSorusu.Size = new System.Drawing.Size(263, 22);
            this.txtHatirlatmaSorusu.TabIndex = 17;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl15.Appearance.Options.UseBorderColor = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl15.Location = new System.Drawing.Point(0, 131);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(160, 27);
            this.labelControl15.TabIndex = 24;
            this.labelControl15.Text = "Parola :";
            // 
            // txtYeniParolaTekrar
            // 
            this.txtYeniParolaTekrar.Location = new System.Drawing.Point(190, 162);
            this.txtYeniParolaTekrar.Name = "txtYeniParolaTekrar";
            this.txtYeniParolaTekrar.Properties.UseSystemPasswordChar = true;
            this.txtYeniParolaTekrar.Size = new System.Drawing.Size(263, 22);
            this.txtYeniParolaTekrar.TabIndex = 18;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl14.Appearance.Options.UseBorderColor = true;
            this.labelControl14.Appearance.Options.UseTextOptions = true;
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl14.Location = new System.Drawing.Point(0, 47);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(160, 27);
            this.labelControl14.TabIndex = 25;
            this.labelControl14.Text = "Kullanıcı Adı veya E-mail :";
            // 
            // txtYeniParola
            // 
            this.txtYeniParola.Location = new System.Drawing.Point(190, 134);
            this.txtYeniParola.Name = "txtYeniParola";
            this.txtYeniParola.Properties.UseSystemPasswordChar = true;
            this.txtYeniParola.Size = new System.Drawing.Size(263, 22);
            this.txtYeniParola.TabIndex = 19;
            // 
            // txtKullaniciAdiEmail
            // 
            this.txtKullaniciAdiEmail.Location = new System.Drawing.Point(190, 50);
            this.txtKullaniciAdiEmail.Name = "txtKullaniciAdiEmail";
            this.txtKullaniciAdiEmail.Properties.NullText = "Kullanıcı Adı veya Email Adresinizi Giriniz";
            this.txtKullaniciAdiEmail.Properties.NullValuePrompt = "Kullanıcı Adı veya Email Adresinizi Giriniz";
            this.txtKullaniciAdiEmail.Size = new System.Drawing.Size(263, 22);
            this.txtKullaniciAdiEmail.TabIndex = 20;
            // 
            // frmParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.txtHatirlatmaSorusu);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.txtYeniParolaTekrar);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtYeniParola);
            this.Controls.Add(this.txtKullaniciAdiEmail);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmParolamiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Yenileme";
            this.Load += new System.EventHandler(this.frmParolamiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHatirlatmaSorusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdiEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtHatirlatmaSorusu;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtYeniParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtYeniParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdiEmail;
    }
}