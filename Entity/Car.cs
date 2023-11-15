using System.ComponentModel.DataAnnotations;

namespace graphql_dummy_data.Entity
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }

    }
}