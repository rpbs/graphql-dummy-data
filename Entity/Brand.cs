using System.ComponentModel.DataAnnotations;

namespace graphql_dummy_data.Entity
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
