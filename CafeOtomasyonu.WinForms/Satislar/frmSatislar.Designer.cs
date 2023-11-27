namespace CafeOtomasyonu.WinForms.Satislar
{
    partial class frmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExport = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfExport = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisDetaylari = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimToplami = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaketSiparişMi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(1016, 31);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Satışlar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnOdemeHareketleri);
            this.groupControl1.Controls.Add(this.btnSiparisDetaylari);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 463);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1016, 125);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.DropDownControl = this.popupMenu1;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(765, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 71);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Dışa Aktar";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfExport)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel Dosyaları(*.xlsx)";
            this.btnExcelExport.Id = 0;
            this.btnExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.Image")));
            this.btnExcelExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.LargeImage")));
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Tag = "Excel Dosyaları(*.xlsx)|*.xlsx";
            this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnWordExport
            // 
            this.btnWordExport.Caption = "Word Dosyaları(*.docx)";
            this.btnWordExport.Id = 1;
            this.btnWordExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordExport.ImageOptions.Image")));
            this.btnWordExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWordExport.ImageOptions.LargeImage")));
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Tag = "Word Dosyaları(*.docx)|*.docx";
            this.btnWordExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.Caption = "PDF Dosyları(*.pdf)";
            this.btnPdfExport.Id = 2;
            this.btnPdfExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.ImageOptions.Image")));
            this.btnPdfExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.ImageOptions.LargeImage")));
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Tag = "PDF Dosyları(*.pdf)|*.pdf";
            this.btnPdfExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWordExport,
            this.btnPdfExport});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1016, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1016, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 588);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1016, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 588);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(248, 49);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(128, 57);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile-Listele";
            // 
            // btnOdemeHareketleri
            // 
            this.btnOdemeHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeHareketleri.ImageOptions.Image")));
            this.btnOdemeHareketleri.Location = new System.Drawing.Point(130, 49);
            this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
            this.btnOdemeHareketleri.Size = new System.Drawing.Size(112, 57);
            this.btnOdemeHareketleri.TabIndex = 1;
            this.btnOdemeHareketleri.Text = "Ödeme\r\nHareketleri\r\n";
            this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
            // 
            // btnSiparisDetaylari
            // 
            this.btnSiparisDetaylari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisDetaylari.ImageOptions.Image")));
            this.btnSiparisDetaylari.Location = new System.Drawing.Point(12, 49);
            this.btnSiparisDetaylari.Name = "btnSiparisDetaylari";
            this.btnSiparisDetaylari.Size = new System.Drawing.Size(112, 57);
            this.btnSiparisDetaylari.TabIndex = 1;
            this.btnSiparisDetaylari.Text = "Sipariş\r\nDetayları";
            this.btnSiparisDetaylari.Click += new System.EventHandler(this.btnSiparisDetaylari_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(910, 42);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 71);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1016, 432);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colMusteriAdSoyad,
            this.colMusteriId,
            this.colTutar,
            this.colIndirimToplami,
            this.colOdenen,
            this.colKalan,
            this.colAciklama,
            this.colSonIslemTarihi,
            this.colPaketSiparişMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 53;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.MinWidth = 25;
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.OptionsColumn.AllowEdit = false;
            this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Kayıt : {0}")});
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            this.colSatisKodu.Width = 120;
            // 
            // colMusteriAdSoyad
            // 
            this.colMusteriAdSoyad.Caption = "Müşteri Ad Soyad";
            this.colMusteriAdSoyad.FieldName = "Musteriler.AdiSoyadi";
            this.colMusteriAdSoyad.MinWidth = 25;
            this.colMusteriAdSoyad.Name = "colMusteriAdSoyad";
            this.colMusteriAdSoyad.OptionsColumn.AllowEdit = false;
            this.colMusteriAdSoyad.Visible = true;
            this.colMusteriAdSoyad.VisibleIndex = 2;
            this.colMusteriAdSoyad.Width = 129;
            // 
            // colMusteriId
            // 
            this.colMusteriId.FieldName = "MusteriId";
            this.colMusteriId.MinWidth = 25;
            this.colMusteriId.Name = "colMusteriId";
            this.colMusteriId.OptionsColumn.AllowEdit = false;
            this.colMusteriId.Width = 71;
            // 
            // colTutar
            // 
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "Tutar={0:C2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 54;
            // 
            // colIndirimToplami
            // 
            this.colIndirimToplami.DisplayFormat.FormatString = "C2";
            this.colIndirimToplami.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimToplami.FieldName = "IndirimToplami";
            this.colIndirimToplami.MinWidth = 25;
            this.colIndirimToplami.Name = "colIndirimToplami";
            this.colIndirimToplami.OptionsColumn.AllowEdit = false;
            this.colIndirimToplami.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IndirimToplami", "{0:C2}")});
            this.colIndirimToplami.Visible = true;
            this.colIndirimToplami.VisibleIndex = 4;
            this.colIndirimToplami.Width = 132;
            // 
            // colOdenen
            // 
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.MinWidth = 25;
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.OptionsColumn.AllowEdit = false;
            this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "{0:C2}")});
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 5;
            this.colOdenen.Width = 76;
            // 
            // colKalan
            // 
            this.colKalan.DisplayFormat.FormatString = "C2";
            this.colKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalan.FieldName = "Kalan";
            this.colKalan.MinWidth = 25;
            this.colKalan.Name = "colKalan";
            this.colKalan.OptionsColumn.AllowEdit = false;
            this.colKalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kalan", "{0:C2}")});
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 6;
            this.colKalan.Width = 60;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 231;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.MinWidth = 25;
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 8;
            this.colSonIslemTarihi.Width = 131;
            // 
            // colPaketSiparişMi
            // 
            this.colPaketSiparişMi.Caption = "Paket Sipariş Mi";
            this.colPaketSiparişMi.FieldName = "PaketSiparisMi";
            this.colPaketSiparişMi.MinWidth = 25;
            this.colPaketSiparişMi.Name = "colPaketSiparişMi";
            this.colPaketSiparişMi.OptionsColumn.AllowEdit = false;
            this.colPaketSiparişMi.Visible = true;
            this.colPaketSiparişMi.VisibleIndex = 9;
            this.colPaketSiparişMi.Width = 94;
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 588);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.frmSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnOdemeHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnSiparisDetaylari;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriId;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimToplami;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalan;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketSiparişMi;
        private DevExpress.XtraEditors.DropDownButton btnExport;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnWordExport;
        private DevExpress.XtraBars.BarButtonItem btnPdfExport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}