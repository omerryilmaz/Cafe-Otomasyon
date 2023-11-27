using CafeOtomasyonu.Entities.Interfaces;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Repository;
using CafeOtomasyonu.Entities.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.DataAccessLayer
{
    public class KullaniciHareketleriDal : EntityRepositoryBase<CafeContext, KullaniciHareketleri, KullaniciHareketleriValidator>
    {
        //public static int kullaniciId { get; set; }
        public void KullaniciHareketleriEkle(CafeContext context, KullaniciHareketleri kullaniciHareketleri, string aciklama)
        {
            KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();

            kullaniciHareketleri.Tarih = DateTime.Now;
            kullaniciHareketleri.Aciklama = aciklama;

            if (kullaniciHareketleriDal.AddOrUpdate(context, kullaniciHareketleri))
            {
                kullaniciHareketleriDal.Save(context);
            }
        }

    }
}
