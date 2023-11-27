using CafeOtomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class KullaniciHareketleri : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }

    }
}
