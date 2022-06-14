using Application.Common.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Tokens
{
    public record TokenRequest(string Email, string Password);

    public class TokenRequestValidator : CustomValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
                .NotEmpty()
                .EmailAddress()
                    .WithMessage("Invalid Email Address.");

            RuleFor(p => p.Password).Cascade(CascadeMode.Stop)
                .NotEmpty();
        }
    }
}
