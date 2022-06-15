using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Notifications
{
    public class SignalRSettings
    {
        public class Backplane
        {
            public string? Provider { get; set; }
            public string? StringConnection { get; set; }
        }

        public bool UseBackplane { get; set; }
    }
}
