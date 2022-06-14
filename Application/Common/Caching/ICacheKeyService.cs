using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Caching
{
    public interface ICacheKeyService : IScopedService
    {
        public string GetCacheKey(string name, object id, bool includeTenantId = true);
    }
}
