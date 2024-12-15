using WebApplication4.Controllers;

namespace WebApplication4.Services
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(string email, string password);
    }
}