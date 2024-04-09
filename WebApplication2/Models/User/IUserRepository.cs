namespace WebApplication2.Models.User
{
    public interface IUserRepository
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
        User Add(User User);
        User Update(User User);
        User Delete(int id);
    }
}
