using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Middleware
{
    public class MiddlewareSettings
    {
        public bool EnableHttpsLogging { get; set; } = false;
        public bool EnableLocalization { get; set; } = false;
    }
}
