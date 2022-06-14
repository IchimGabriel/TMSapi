using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Persistence
{
    public interface IConnectionStringSecurer
    {
        string? MakeSecure(string? connectionString, string? dbProvider = null);
    }
}
