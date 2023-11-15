using graphql_dummy_data.Entity;

namespace graphql_dummy_data.Interfaces;

public interface IBrandRepository
{
    Task<int> AddBrand();
    Task<List<Brand>> GetBrands();
    Task<Brand> GetById(int id);
}
