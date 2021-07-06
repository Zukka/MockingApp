using MockingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MockingApp.Services
{
    public class ApiManager : IApiManager
    {
        public string BaseUrl = "";
        public async Task<bool> Login(User user)
        {
            //Do request here
            return true;
        }
        public async Task<List<Dog>> GetDogs()
        {
            //Do request here
            return null;
        }
    }
}
