using webapi_challenge.Models;
using webapi_challenge.Repository;

namespace webapi_challenge.Service
{
    public class BusService : IBusService 
    { 

        private readonly IBusRepository _busRepository;

        public BusService(IBusRepository busRepository)
    {
        this._busRepository = busRepository;
    }
  
        public Bus Create(Bus bus)
        {
            //business  logics
            return _busRepository.Add(bus);
        }

        public Bus Delete(int id)
        {
            var deleteBus = _busRepository.GetById(id);
            return _busRepository.Delete(deleteBus);
        }

        public List<Bus> GetAll()
        {
            return _busRepository.GetAll();
        }

        public List<Bus> GetByColor(string color)
        {
            return _busRepository.GetByColor(color);
        }

        public Bus GetBus(int id)
        {
            return _busRepository.GetById(id);
        }

        public Bus UpdateById(Bus bus, int id)
        {
            return _busRepository.UpdateById(bus, id);
        }
    }
}
