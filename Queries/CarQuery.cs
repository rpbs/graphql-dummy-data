using GraphQL;
using GraphQL.Types;
using graphql_dummy_data.Interfaces;
using graphql_dummy_data.Types;

namespace graphql_dummy_data.Queries
{
    public class CarQuery : ObjectGraphType
    {
        public CarQuery(ICarRepository carRepository, IBrandRepository brandRepository)
        {
            Field<ListGraphType<CarType>>("cars").ResolveAsync(async context =>
            {
                return await carRepository.GetCars();
            });

            Field<CarType>("car").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "carId" })).ResolveAsync(async context =>
            {
                var car = await carRepository.GetById(context.GetArgument<int>("carId"));
                return car;
            });
        }
    }
}
