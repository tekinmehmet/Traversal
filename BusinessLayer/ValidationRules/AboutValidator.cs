using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public string EmptyMessage { get; } = "{PropertyName} alanı boş olamaz.";
        public AboutValidator()
        {

            RuleFor(x => x.Description).NotEmpty().WithMessage(EmptyMessage);
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Minimum 50 karakter giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("{PropertyName} alanı en fazla {MaxLength} karakter olabilir.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz.");
        }
    }
}
