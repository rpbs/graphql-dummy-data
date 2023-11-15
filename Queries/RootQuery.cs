using GraphQL.Types;

namespace graphql_dummy_data.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery() 
        {
            Field<CarQuery>("carQuery").Resolve(context => new { });
            Field<BrandQuery>("brandQuery").Resolve(context => new { });
        }
    }
}
