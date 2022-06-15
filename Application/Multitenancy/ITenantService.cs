using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Multitenancy
{
    public interface ITenantService
    {
        Task<List<TenantDto>> GetAllAsync();
        Task<bool> ExistsWithIdAsync(string id);
        Task<bool> ExistsWithNameAsync(string name);
        Task<TenantDto> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateTenantRequest request, CancellationToken cancellationToken);
        Task<string> ActivateAsync(string id);
        Task<string> DeactivateAsync(string id);
        Task<string> UpdateSubscription(string id, DateTime extendedExpiryDate);
    }
}
