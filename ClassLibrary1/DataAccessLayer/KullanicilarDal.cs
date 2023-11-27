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
    public class KullanicilarDal : EntityRepositoryBase<CafeContext, Kullanicilar,KullanicilarValidator>
    {

    }
}
