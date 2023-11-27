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
    public class UrunDal : EntityRepositoryBase<CafeContext, Urun,UrunValidator>{
    public object UrunListele(CafeContext context)
    {
        var liste = (from u in context.Urun
            select new
            {
                u.Id,
                u.MenuId,
                Menu=u.Menu.MenuAdi,
                u.UrunKodu,
                u.UrunAdi,
                u.BirimFiyat1,
                u.BirimFiyat2,
                u.BirimFiyat3,
                u.Aciklama,
                u.Resim,
                u.Tarih,
                u.HizliSatis,
            }).ToList();
        return liste;
    }
    }
}
