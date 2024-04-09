
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Models.Race
{
    public class RaceRepository : IRaceRepository
    { 
        private readonly ApplicationDBContext _dbContext;
        public RaceRepository(ApplicationDBContext dBContext)
        {
            this._dbContext = dBContext;
        }
        public Race Add(Race race)
        {
            throw new NotImplementedException();
        }

        public Race Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Race> GetAll()
        {
            return this._dbContext.Races.ToList();
        }

        public Race GetByDescription(int title)
        {
            throw new NotImplementedException();
        }

        public Race GetById(int id)
        {
            return _dbContext.Races.Include(r => r.Address).SingleOrDefault(r => r.Id == id);
        }

        public Race GetByTitle(int title)
        {
            throw new NotImplementedException();
        }

        public Race Update(Race race)
        {
            throw new NotImplementedException();
        }
    }
}
