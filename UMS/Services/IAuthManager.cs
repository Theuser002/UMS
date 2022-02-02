using System.Threading.Tasks;
using UMS.Models;

namespace UMS.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDto loginUserDto);
        Task<string> CreateToken();
    }
}
