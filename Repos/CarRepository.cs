using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;

namespace graphql_dummy_data.Repos
{
    public class CarRepository : ICarRepository
    {
        readonly List<Car> cars = new()
        {
            new Car{ Id = 1, Description = "Good engine sound", Name = "Camaro", Price = 1000, BrandId = 1 },
            new Car{ Id = 2, Description = "This a big one", Name = "Grand Santa Fé", Price = 1000, BrandId = 2 },
            new Car{ Id = 3, Description = "Nice", Name = "Civic", Price = 1000, BrandId = 3 },
        };


        public int AddCar()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int v)
        {
            return cars.FirstOrDefault(x => x.Id == v);
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
