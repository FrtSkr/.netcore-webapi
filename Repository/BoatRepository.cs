using Microsoft.EntityFrameworkCore;
using webapi_challenge.Data;
using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public class BoatRepository : IBoatRepository
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<Boat> _dbSet;

        public BoatRepository(DatabaseContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<Boat>();
        }

        public Boat Add(Boat entity)
        {
            var result = new Boat();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;

            return result;
        }

        public Boat Delete(Boat entity)
        {
            var result = new Boat();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<Boat> GetAll()
        {
            var result = new List<Boat>();
            var list = _dbSet.ToList();
            if (list != null)
                result = list;
            else
                result = null;

            return result;
        }

        public List<Boat> GetByColor(string color)
        {
            var result = new List<Boat>();
            result = _context.Boats
                .Where(
                    boats => boats.color.Contains(color))
                .ToList();

            return result;
        }

        public Boat GetById(int id)
        {
            var result = new Boat();
            result = _dbSet.Find(id);

            return result;
        }

        public Boat UpdateById(Boat entity, int id)
        {
            var result = new Boat();
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
