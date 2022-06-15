using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Multitenancy
{
    public class GetAllTenantsRequest : IRequest<List<TenantDto>>
    {
    }

    public class GetAllTenantsRequestHandler : IRequestHandler<GetAllTenantsRequest, List<TenantDto>>
    {
        private readonly ITenantService _tenantService;

        public GetAllTenantsRequestHandler(ITenantService tenantService) => _tenantService = tenantService;

        public Task<List<TenantDto>> Handle(GetAllTenantsRequest request, CancellationToken cancellationToken) =>
            _tenantService.GetAllAsync();
    }
}
