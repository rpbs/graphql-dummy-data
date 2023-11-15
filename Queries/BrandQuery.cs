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
            Field<ListGraphType<BrandType>>("brands").ResolveAsync(async context =>
            {
                return await brandRepository.GetBrands();
            });

            Field<BrandType>("brand").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "brandId" })).ResolveAsync(async context =>
            {
                Brand car = await brandRepository.GetById(context.GetArgument<int>("brandId"));
                return car;
            });

        }
    }
}
