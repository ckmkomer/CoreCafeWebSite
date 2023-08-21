using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class ChefValidation : AbstractValidator<Chef>
    {
        public ChefValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapılabilir.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karekter girişi yapınız.");
        }
    }
}
