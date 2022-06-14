using Application.Common.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Users.Password
{
    public class ForgotPasswordRequest
    {
        public string Email { get; set; } = default!;
    }

    public class ForgotPasswordRequestValidator : CustomValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator() =>
            RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
                .NotEmpty()
                .EmailAddress()
                    .WithMessage("Invalid Email Address.");
    }
}
