
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Models.User
{
    public class UserRepository : IUserRepository
    {
       private readonly ApplicationDBContext _dbContext;

        public UserRepository(ApplicationDBContext dBContext)
           
        {
            this._dbContext = dBContext;
        }
        public User Add(User User)
        {
            this._dbContext.Users.Add(User);
            _dbContext.SaveChanges();
            return User;

        }

        public User Delete(int id)
        {
            User user = _dbContext.Users.Find(id);
            if(user == null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
            return user;
           
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users = _dbContext.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            return _dbContext.Users.Include(a=> a.Address).FirstOrDefault(u => u.Id == id);
        }

        public User Update(User User)
        {
            //User user = _dbContext.Users.Find(User.Email);
            //if(user == null )
            //{
            //    user.Address = User.Address;
            //    user.Email = User.Email;
            //    _dbContext.SaveChanges();
            //}
            var user = _dbContext.Users.Attach(User);
            user.State = EntityState.Modified;
            _dbContext.SaveChanges();
            return User;
        }
    }
}
