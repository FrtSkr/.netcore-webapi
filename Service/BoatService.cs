using webapi_challenge.Models;
using webapi_challenge.Repository;

namespace webapi_challenge.Service
{
    public class BoatService : IBoatService
    {
        private readonly IBoatRepository _boatRepository;

        public BoatService(IBoatRepository boatRepository)
        {
            this._boatRepository = boatRepository;
        }
        public Boat Create(Boat boat)
        {
            //business  logics
            return _boatRepository.Add(boat);
        }

        public Boat Delete(int id)
        {
            var deleteBoat = _boatRepository.GetById(id);
            return _boatRepository.Delete(deleteBoat);
        }

        public List<Boat> GetAll()
        {
            return _boatRepository.GetAll();
        }

        public List<Boat> GetByColor(string color)
        {
            return _boatRepository.GetByColor(color);
        }

        public Boat UpdateById(Boat boat, int id)
        {
            return _boatRepository.UpdateById(boat, id);
        }

        public Boat GetBoat(int id)
        {
            return _boatRepository.GetById(id);
        }
    }
}
