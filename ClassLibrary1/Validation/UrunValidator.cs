using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validation
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün Kodu alanı boş geçilemez!");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün Adı alanı boş geçilemez!");

            RuleFor(p => p.BirimFiyat1).NotEmpty().WithMessage("Birim Fiyatı 1 alanı boş geçilemez!");
            RuleFor(p => p.BirimFiyat1).GreaterThanOrEqualTo(0).WithMessage("Birim Fiyatı 1 0'dan küçük olamaz!");
            RuleFor(p => p.BirimFiyat2).NotEmpty().WithMessage("Birim Fiyatı 2 alanı boş geçilemez!");
            RuleFor(p => p.BirimFiyat2).GreaterThanOrEqualTo(0).WithMessage("Birim Fiyatı 2 0'dan küçük olamaz!");
            RuleFor(p => p.BirimFiyat3).NotEmpty().WithMessage("Birim Fiyatı 3 alanı boş geçilemez!");
            RuleFor(p => p.BirimFiyat3).GreaterThanOrEqualTo(0).WithMessage("Birim Fiyatı 3 0'dan küçük olamaz!");

        }
    }
}
