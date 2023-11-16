using GraphQL;
using GraphQL.Types;
using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;
using graphql_dummy_data.Types;

namespace graphql_dummy_data.Queries
{
    public class CarQuery : ObjectGraphType
    {
        public CarQuery(ICarRepository carRepository, IBrandRepository brandRepository)
        {
            Field<ListGraphType<CarType>>("cars").Resolve(context =>
            {
                var cars = carRepository.GetCars();

                cars.ForEach(x => x.Brand = brandRepository.GetById(x.BrandId));

                return carRepository.GetCars();
            });

            Field<CarType>("car").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "carId" })).Resolve(context =>
            {
                var car = carRepository.GetById(context.GetArgument<int>("carId"));

                car.Brand = brandRepository.GetById(car.BrandId);

                return car;
            });
        }
    }
}
