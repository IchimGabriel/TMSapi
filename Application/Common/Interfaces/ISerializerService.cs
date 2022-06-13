using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ISerializerService : ITransientService
    {
        string Serialize<T>(T obj);

        string Serialize<T>(T obj, Type type);

        T Deserialize<T>(string text);
    }
}
