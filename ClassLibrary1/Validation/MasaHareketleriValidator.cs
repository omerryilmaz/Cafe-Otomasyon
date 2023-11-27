using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validation
{
    public class MasaHareketleriValidator : AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez!");
            //RuleFor(p => p.SatisKodu).Length(12).WithMessage("Satış kodu 12 karakterden oluşmalıdır!");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Miktar alanı boş geçilemez!");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("Miktar 0'dan küçük olamaz!");
            RuleFor(p => p.BirimFiyati).NotEmpty().WithMessage("Birim Fiyatı alanı boş geçilemez!");
            RuleFor(p => p.BirimFiyati).GreaterThanOrEqualTo(0).WithMessage("Birim Fiyatı 0'dan küçük olamaz!");
        }
    }
}
