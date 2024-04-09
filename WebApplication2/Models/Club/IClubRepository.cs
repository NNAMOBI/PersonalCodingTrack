namespace WebApplication2.Models.Club
{
    public interface IClubRepository
    {

        Task<Club> GetByTitle(string title);
        Task<Club> GetById(int id);
        Task<Club> GetByIdNoTracking(int id);
        Task<IEnumerable<Club>> GetAll();
        Task<IEnumerable<Club>> GetClubByCity(string city);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(int id);
    }
}
