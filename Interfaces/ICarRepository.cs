using graphql_dummy_data.Entity;

namespace graphql_dummy_data.Interfaces;

public interface ICarRepository
{
    List<Car> GetCars();
    int AddCar();
    Car GetById(int v);
}
