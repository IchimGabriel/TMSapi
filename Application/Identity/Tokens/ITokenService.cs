using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Tokens
{
    public interface ITokenService : ITransientService
    {
        Task<TokenResponse> GetTokenAsync(TokenRequest request, string ipAddress, CancellationToken cancellationToken);

        Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request, string ipAddress);
    }
}
