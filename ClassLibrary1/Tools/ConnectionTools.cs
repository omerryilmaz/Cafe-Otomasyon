using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using Menu = CafeOtomasyonu.Entities.Models.Menu;

namespace CafeOtomasyonu.Entities.Tools
{
    public class ConnectionTools
    {
        public static string baglan()
        {
            string readStr;
            string path = @"ConnectionStr\baglanti.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader=new StreamReader(fileStream))
            {
                string row = reader.ReadLine();
                readStr = row;
                reader.Close();
            }
            fileStream.Close();
            return readStr;
        }
        public static void BaglantiKontrol()
        {
            using (var context = new CafeContext())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show("Veritabanınız oluşturulacak. Daha sonra ayrı bir forma yönlendirileceksiniz.");
                    context.Database.CreateIfNotExists();
                }
                
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<CafeContext,Entities.Migrations.Configuration>());
            }
        }

        public static void VeriDoldur(CafeContext context)
        {
            if (!context.Masalar.Any())
            {
                List<Masalar> list = new List<Masalar>()
                {
                    new Masalar
                    {
                        MasaAdi = "Masa-1",
                        Aciklama = "A Grubu 1. Sıra",
                        Islem = "Masa-1 oluşturuldu."
                    },
                    new Masalar
                    {
                        MasaAdi = "Masa-2",
                        Aciklama = "A Grubu 2. Sıra",
                        Islem = "Masa-2 oluşturuldu."
                    },
                    new Masalar
                    {
                        MasaAdi = "Masa-3",
                        Aciklama = "A Grubu 3. Sıra",
                        Islem = "Masa-3 oluşturuldu."
                    },
                };
                context.Masalar.AddRange(list);
            }

            if (!context.Menu.Any())
            {
                List<Menu> menulist = new List<Menu>
                {
                    new Menu
                    {
                        MenuAdi = "Sıcak İçecekler",
                        Aciklama = "Sıcak İçecekler Grubu"
                    },
                    new Menu
                    {
                        MenuAdi = "Soğuk İçecekler",
                        Aciklama = "Soğuk İçecekler Grubu"
                    },
                    new Menu
                    {
                        MenuAdi = "Tatlılar",
                        Aciklama = "Tatlılar Grubu"
                    },
                };
                context.Menu.AddRange(menulist);
            }
            if (!context.SatisKodu.Any())
            {
                List<SatisKodu> satiskoduList = new List<SatisKodu>
                {
                    new SatisKodu
                    {
                        SatisTanimi = "Satış",
                        Sayi = 1
                    },

            };
                context.SatisKodu.AddRange(satiskoduList);
            }

            context.SaveChanges();
        }
    }
}
