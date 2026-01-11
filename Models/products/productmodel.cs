using System.ComponentModel.DataAnnotations;

namespace startup.Models.products
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

       public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

       public int Quantity { get; set; }

        public string Slug { get; set; }

        public string Rom { get; set; }

        public string Ram { get; set; }

        public string Chip { get; set; }

        public string Image { get; set; }

        public DateTime DateCreated { get; set; }
    }

}
