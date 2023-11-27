using CafeOtomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    
    public class Masalar : IEntity
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durumu { get; set; } = false;
        public bool RezerveMi { get; set; } = false;
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
        public DateTime SonIslemTarihi { get; set; }= DateTime.Now;
        public string Islem { get; set; }
        public string SatisKodu { get; set; }
        public int? KullaniciId { get; set; }
        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }


    }
}
