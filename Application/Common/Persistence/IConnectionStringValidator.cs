using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Persistence
{
    public interface IConnectionStringValidator
    {
        bool TryValidate(string connectionString, string? dbProvider = null);
    }
}
