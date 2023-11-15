using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;

namespace graphql_dummy_data.Repos
{
    public class BrandRepository : IBrandRepository
    {

        List<Brand> brands = new()
        {

        };

        public Task<int> AddBrand()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await dbContext.Brands.ToListAsync();
        }

        public async Task<Brand> GetById(int id)
        {
            return await dbContext.Brands.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
