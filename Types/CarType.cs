using GraphQL.Types;
using graphql_dummy_data.Entity;
using Microsoft.EntityFrameworkCore;

namespace graphql_dummy_data.Types;

public class CarType : ObjectGraphType<Car>
{
    //GraphQLContext dbContext;

    //public CarType(GraphQLContext dbContext)
    //{
    //    this.dbContext = dbContext;
    //}

    public CarType()
	{
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("description");
        Field<DecimalGraphType>("price");
        Field<IntGraphType>("brandId");
        Field(x => x.Brand);
        

    }
}
