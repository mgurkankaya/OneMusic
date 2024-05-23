using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Validators
{
    public class CustomErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Description = "Şifre en az 6 karakter olmalıdır!"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Description = "En az 1 rakam (0-9) içermelidir.!"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Description = "En az 1 küçük harf (a-z) içermelidir!"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Description = "En az 1 büyük harf (A-Z) içermelidir!"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Description = "En az 1 özel karakter (*,-,?,+,$...)  içermelidir!"
            };
        }

      

    }
}
