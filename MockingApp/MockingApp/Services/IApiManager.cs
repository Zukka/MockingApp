using MockingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MockingApp.Services
{
    public interface IApiManager
    {
        Task<bool> Login(User user);
        Task<List<Dog>> GetDogs();
    }
}
