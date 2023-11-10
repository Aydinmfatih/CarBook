using FluentValidation;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.ValidationRules.ServiceValidation
{
    public class CreateServiceValidator : AbstractValidator<Service>
    {
        public CreateServiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş geçemessiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçemessiniz");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon boş geçemessiniz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("En az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Description).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
        }
    }
}
