using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Roles
{
    public interface IRoleService : ITransientService
    {
        Task<List<RoleDto>> GetListAsync(CancellationToken cancellationToken);

        Task<int> GetCountAsync(CancellationToken cancellationToken);

        Task<bool> ExistsAsync(string roleName, string? excludeId);

        Task<RoleDto> GetByIdAsync(string id);

        Task<RoleDto> GetByIdWithPermissionsAsync(string roleId, CancellationToken cancellationToken);

        Task<string> CreateOrUpdateAsync(CreateOrUpdateRoleRequest request);

        Task<string> UpdatePermissionsAsync(UpdateRolePermissionsRequest request, CancellationToken cancellationToken);

        Task<string> DeleteAsync(string id);
    }
}
