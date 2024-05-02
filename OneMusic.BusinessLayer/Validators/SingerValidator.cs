using FluentValidation;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Validators
{
    public class SingerValidator: AbstractValidator<Singer>
    {
        public SingerValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu alan boş bırakılamaz.").MaximumLength(50).WithMessage("50 karakteri aşmamalı").MinimumLength(4).WithMessage("4 karakterden az olamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
    }
}
