﻿// <autogenerated>
//   This file was generated by T4 code generator Main.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace SanXing.ViewModels.Validator
{
    public class TimeCostTypeValidator : AbstractValidator<TimeCostTypeModel>
    {
        public TimeCostTypeValidator()
        {
            RuleFor(x => x.CateName)
                .NotEmpty().WithMessage("请输入类别名称");

            RuleFor(x => x.Code).NotEmpty().WithMessage("请输入类别名称代码");
        }
    }
}
