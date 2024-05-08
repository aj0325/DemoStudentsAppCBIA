using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.Services
{
    public class MockAuthenticationService : IAuthenticationService
    {
        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            // Mock authentication logic
            return await Task.FromResult(username == "John" && password == "Pass123");
        }
    }

    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string username, string password);
    }
}


