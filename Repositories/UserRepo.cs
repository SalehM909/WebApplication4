using WebApplication4.Controllers;

namespace WebApplication4.Repositories
{
    public class UserRepo : IUserRepo
    {

        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public User GetUSer(string email, string password)
        {
            return _context.users.Where(u => u.Email == email & u.Password == password).FirstOrDefault();
        }

    }
}
