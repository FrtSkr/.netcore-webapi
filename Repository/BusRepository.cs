using Microsoft.EntityFrameworkCore;
using webapi_challenge.Data;
using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public class BusRepository : IBusRepository
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<Bus> _dbSet;

        public BusRepository(DatabaseContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<Bus>();
            
        }

        public Bus Add(Bus entity)
        {
            var result = new Bus();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;

            return result;
        }

        public Bus Delete(Bus entity)
        {
            var result = new Bus();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<Bus> GetAll()
        {
            var result = new List<Bus>();
            var list = _dbSet.ToList();
            if (list != null)
                result = list;
            else
                result = null;

            return result;
        }

        public List<Bus> GetByColor(string color)
        {
            var result = new List<Bus>();
            result = _context.Buses
                .Where(
                    buses => buses.color.Contains(color))
                .ToList();

            return result;
        }

        public Bus GetById(int id)
        {
            var result = new Bus();
            result = _dbSet.Find(id);

            return result;
        }

        public Bus UpdateById(Bus entity, int id)
        {
            var result = new Bus();
            var model = _dbSet.Find(id);

            if (model == null)
                return null;

            _context.Entry(model).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            result = model;

            return result;
        }
    }
}
