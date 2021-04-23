using JWT_Demo.Models;
using System.Threading.Tasks;

namespace JWT_Demo.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);

         
    }
}
