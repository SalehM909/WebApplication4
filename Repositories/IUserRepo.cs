using WebApplication4.Controllers;

namespace WebApplication4.Repositories
{
    public interface IUserRepo
    {
        void AddUser(User user);
        User GetUSer(string email, string password);
    }
}