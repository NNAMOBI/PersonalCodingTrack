
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Models.Club
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public ClubRepository( ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Add(Club club)
        {
            this._dbContext.Add(club);
            _dbContext.SaveChanges();
            return true;
            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _dbContext.Clubs.ToListAsync();
        }

        public async Task<Club> GetById(int id)
        {
            return await _dbContext.Clubs.Include( a=> a.Address).SingleOrDefaultAsync(e => e.Id == id);
            
        }
        public async Task<Club?> GetByIdNoTracking(int id)
        {
            return await _dbContext.Clubs.Include(i => i.Address).AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Club> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            return await _dbContext.Clubs.Where(a => a.Address.City == city).ToListAsync();
        }

        public bool Update(Club club)
        {
           var isClubUpDated =  _dbContext.Update(club);
            isClubUpDated.State = EntityState.Modified;
            _dbContext.SaveChanges();
            return true;
        }
    }
}
