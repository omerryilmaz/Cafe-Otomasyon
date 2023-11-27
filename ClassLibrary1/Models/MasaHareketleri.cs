using CafeOtomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class MasaHareketleri : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public int? MasaId { get; set; }
        //  public int MenuId { get; set; }
        public int UrunId { get; set; }
        public int Miktari { get; set; }
        public decimal BirimFiyati { get; set; }
       // public decimal IndirimTutari { get; set; }
       public decimal IndirimOrani { get; set; } = 0;
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Masalar Masalar { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
