using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Models;
using FluentValidation;

namespace CafeOtomasyonu.Entities.Validation
{
    public class MusterilerValidator:AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(p => p.AdiSoyadi).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez!");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen E-Mail adresinizi doğru formatta yazınız!");
        } 
       
    }
}
