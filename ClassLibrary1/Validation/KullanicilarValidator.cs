using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validation
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez!");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez!");
            RuleFor(p => p.KullaniciAdi).MinimumLength(3).WithMessage("Kullanıcı Adı 3 karakterden az olamaz!");
            RuleFor(p => p.KullaniciAdi).MaximumLength(10).WithMessage("Kullanıcı Adı 10 karakterden fazla olamaz!");
            RuleFor(p => p.Parola).MinimumLength(3).WithMessage("Kullanıcı Adı 3 karakterden az olamaz!");
            RuleFor(p => p.Parola).MaximumLength(10).WithMessage("Kullanıcı Adı 10 karakterden fazla olamaz!");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez!");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("E-Mail alanı boş geçilemez!");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen E-Mail adresinizi doğru formatta yazınız!");
        }
    }
}
