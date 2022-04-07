using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface IReadUserJson
    {
        Task<List<T>> ReadUserJsonData<T>();
    }
}