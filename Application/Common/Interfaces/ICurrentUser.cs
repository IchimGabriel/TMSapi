using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ICurrentUser
    {
        string? Name { get; }

        Guid GetUserId();

        string? GetUserEmail();

        string? GetTenant();

        bool IsAuthenticated();

        bool IsInRole(string role);

        IEnumerable<Claim>? GetUserClaims();
    }
}
