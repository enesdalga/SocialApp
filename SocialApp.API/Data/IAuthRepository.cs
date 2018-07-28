using System.Threading.Tasks;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> RegisterAsync(User user, string password);
        Task<User> LoginAsync(string username, string password);
        Task<bool> UserExistsAsync(string username);
    }
}