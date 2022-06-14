using Application.Common.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Users.Password
{
    public class ChangePasswordRequest
    {
        public string Password { get; set; } = default!;
        public string NewPassword { get; set; } = default!;
        public string ConfirmNewPassword { get; set; } = default!;
    }

    public class ChangePasswordRequestValidator : CustomValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator()
        {
            RuleFor(p => p.Password)
                .NotEmpty();

            RuleFor(p => p.NewPassword)
                .NotEmpty();

            RuleFor(p => p.ConfirmNewPassword)
                .Equal(p => p.NewPassword)
                    .WithMessage("Passwords do not match.");
        }
    }
}
