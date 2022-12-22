using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public interface IBoatRepository
    {
        Boat Add(Boat entity);
        Boat Delete(Boat entity);
        Boat GetById(int id);
        List<Boat> GetByColor(String color);
        List<Boat> GetAll();
        Boat UpdateById(Boat entity, int id);
    }
}
