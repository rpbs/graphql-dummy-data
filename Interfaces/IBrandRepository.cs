using graphql_dummy_data.Entity;

namespace graphql_dummy_data.Interfaces;

public interface IBrandRepository
{
    int AddBrand(Brand brand);
    List<Brand> GetBrands();
    Brand GetById(int id);
}
