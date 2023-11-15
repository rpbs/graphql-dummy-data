using graphql_dummy_data.Entity;

namespace graphql_dummy_data.Interfaces;

public interface ICarRepository
{
    Task<List<Car>> GetCars();
    Task<int> AddCar();
    Task<Car> GetById(int v);
}
