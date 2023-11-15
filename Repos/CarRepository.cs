using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;

namespace graphql_dummy_data.Repos
{
    public class CarRepository : ICarRepository
    {

        public Task<int> AddCar()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetById(int id)
        {
            return this.dbContext.Cars.Include(x => x.Brand).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Car>> GetCars()
        {
            return this.dbContext.Cars.Include(x => x.Brand).ToListAsync();
        }
    }
}
