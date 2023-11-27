namespace CafeOtomasyonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KullniciHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(maxLength: 150, unicode: false),
                        Telefon = c.String(maxLength: 15, unicode: false),
                        Adres = c.String(maxLength: 500, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Gorevi = c.String(maxLength: 100, unicode: false),
                        KullaniciAdi = c.String(maxLength: 50, unicode: false),
                        Parola = c.String(maxLength: 20, unicode: false),
                        HatirlatmaSorusu = c.String(maxLength: 150, unicode: false),
                        Cevap = c.String(maxLength: 50, unicode: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Masalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MasaAdi = c.String(maxLength: 15, unicode: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Durumu = c.Boolean(nullable: false),
                        RezerveMi = c.Boolean(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        SonIslemTarihi = c.DateTime(nullable: false),
                        Islem = c.String(),
                        SatisKodu = c.String(maxLength: 20, unicode: false),
                        KullaniciId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.MasaHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisKodu = c.String(maxLength: 15, unicode: false),
                        MasaId = c.Int(),
                        UrunId = c.Int(nullable: false),
                        Miktari = c.Int(nullable: false),
                        BirimFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IndirimTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masalar", t => t.MasaId)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.MasaId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        UrunKodu = c.String(maxLength: 15, unicode: false),
                        UrunAdi = c.String(maxLength: 50, unicode: false),
                        BirimFiyat1 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        BirimFiyat2 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        BirimFiyat3 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuAdi = c.String(maxLength: 60, unicode: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdiSoyadi = c.String(maxLength: 150, unicode: false),
                        Telefon = c.String(maxLength: 25, unicode: false),
                        Adres = c.String(maxLength: 200, unicode: false),
                        Email = c.String(maxLength: 150, unicode: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisKodu = c.String(maxLength: 15, unicode: false),
                        MusteriId = c.Int(),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IndirimToplami = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Odenen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kalan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        SonIslemTarihi = c.DateTime(nullable: false),
                        PaketSiparisMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteriler", t => t.MusteriId)
                .Index(t => t.MusteriId);
            
            CreateTable(
                "dbo.New_table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OdemeHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisKodu = c.String(maxLength: 15, unicode: false),
                        OdemeTuru = c.String(maxLength: 50, unicode: false),
                        Odenen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramAyarlari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AyarTanimi = c.String(),
                        AyarAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        FormName = c.String(maxLength: 50, unicode: false),
                        ControlName = c.String(maxLength: 50, unicode: false),
                        ControlCaption = c.String(maxLength: 50, unicode: false),
                        Visible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SatisKodu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisTanimi = c.String(maxLength: 20, unicode: false),
                        Sayi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "MusteriId", "dbo.Musteriler");
            DropForeignKey("dbo.KullniciHareketleri", "KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.MasaHareketleri", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Urun", "MenuId", "dbo.Menu");
            DropForeignKey("dbo.MasaHareketleri", "MasaId", "dbo.Masalar");
            DropForeignKey("dbo.Masalar", "KullaniciId", "dbo.Kullanicilar");
            DropIndex("dbo.Satislar", new[] { "MusteriId" });
            DropIndex("dbo.Urun", new[] { "MenuId" });
            DropIndex("dbo.MasaHareketleri", new[] { "UrunId" });
            DropIndex("dbo.MasaHareketleri", new[] { "MasaId" });
            DropIndex("dbo.Masalar", new[] { "KullaniciId" });
            DropIndex("dbo.KullniciHareketleri", new[] { "KullaniciId" });
            DropTable("dbo.SatisKodu");
            DropTable("dbo.Roller");
            DropTable("dbo.ProgramAyarlari");
            DropTable("dbo.OdemeHareketleri");
            DropTable("dbo.New_table");
            DropTable("dbo.Satislar");
            DropTable("dbo.Musteriler");
            DropTable("dbo.Menu");
            DropTable("dbo.Urun");
            DropTable("dbo.MasaHareketleri");
            DropTable("dbo.Masalar");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.KullniciHareketleri");
        }
    }
}
