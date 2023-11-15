using GraphQL.Types;
using graphql_dummy_data.Entity;

namespace graphql_dummy_data.Types;

public class BrandType : ObjectGraphType<Brand>
{
    public BrandType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("country");
    }
}
