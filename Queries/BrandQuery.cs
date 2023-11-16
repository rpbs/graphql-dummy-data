using GraphQL;
using GraphQL.Types;
using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;
using graphql_dummy_data.Types;

namespace graphql_dummy_data.Queries
{
    public class BrandQuery : ObjectGraphType
    {
        public BrandQuery(IBrandRepository brandRepository)  
        {
            Field<ListGraphType<BrandType>>("brands").Resolve(context =>
            {
                return brandRepository.GetBrands();
            });

            Field<BrandType>("brand").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "brandId" })).Resolve(context =>
            {
                Brand car = brandRepository.GetById(context.GetArgument<int>("brandId"));
                return car;
            });

        }
    }
}
