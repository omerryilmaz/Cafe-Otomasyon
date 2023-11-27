using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validation
{
    public class SatislarValidator:AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez!");
           // RuleFor(p => p.SatisKodu).Length(12).WithMessage("Satış kodu 12 karakterden oluşmalıdır!");
            

        }
    }
}
