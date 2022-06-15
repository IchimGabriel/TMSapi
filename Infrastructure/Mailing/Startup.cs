using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mailing
{
    internal static class Startup
    {
        internal static IServiceCollection AddMailing(this IServiceCollection services, IConfiguration config) =>
            services.Configure<MailSettings>(config.GetSection(nameof(MailSettings)));
    }
}
