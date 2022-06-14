using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exporters
{
    public interface IExcelWriter : ITransientService
    {
        Stream WriteToStream<T>(IList<T> data);
    }
}
