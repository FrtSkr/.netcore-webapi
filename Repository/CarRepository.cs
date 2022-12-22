using Microsoft.EntityFrameworkCore;
using webapi_challenge.Data;
using webapi_challenge.Models;

namespace webapi_challenge.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<Car> _dbSet;
        public CarRepository(DatabaseContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<Car>();
        }
        public Car Add(Car entity)
        {
            var result = new Car();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;

            return result;
        }

        public Car Delete(Car entity)
        {
            var result = new Car();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<Car> GetAll()
        {
            var result = new List<Car>();
            var list = _dbSet.ToList();
            if (list != null)
                result = list;
            else
                result = null;

            return result;
        }

        public List<Car> GetByColor(string color)
        {
            var result = new List<Car>();
            result = _context.Cars
                .Where(
                    cars => cars.color.Contains(color))
                .ToList();

            return result;
        }

        public Car GetById(int id)
        {
            var result = new Car();
            result = _dbSet.Find(id);
            
            return result;
        }

        public Car UpdateById(Car entity, int id)
        {
            var result = new Car();
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
