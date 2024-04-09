namespace WebApplication2.Models.Race
{
    public interface IRaceRepository
    {
        Race GetByTitle(int title);

        Race GetById(int id);
        Race GetByDescription(int title);
        IEnumerable<Race> GetAll();
        Race Add(Race race);
        Race Update(Race race);
        Race Delete(int id);
    }
}
