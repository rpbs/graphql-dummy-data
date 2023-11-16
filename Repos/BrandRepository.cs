using graphql_dummy_data.Entity;
using graphql_dummy_data.Interfaces;

namespace graphql_dummy_data.Repos
{
    public class BrandRepository : IBrandRepository
    {
        readonly List<Brand> brands = new()
        {
            new Brand()
            {
                Id = 1,
                Name = "GM",
                Country = "US",
            },
            new Brand()
            {
                Id = 2,
                Name = "Hyunday",
                Country = "KR",
            },
            new Brand()
            {
                Id = 3,
                Name = "Toyota",
                Country = "JP",
            }
        };

        public int AddBrand(Brand brand)
        {
            brands.Add(brand);
            return brand.Id;
        }

        public List<Brand> GetBrands()
        {
            return brands;
        }

        public Brand GetById(int id)
        {
            return brands.FirstOrDefault(x => x.Id == id);
        }
    }
}
