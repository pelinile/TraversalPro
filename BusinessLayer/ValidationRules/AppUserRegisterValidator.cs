using DTOLayer.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş bırakılamaz.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Lütfen en fazla 20 karakter giriniz.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbirleriyle uyuşmuyor.");
        }
    }
}
