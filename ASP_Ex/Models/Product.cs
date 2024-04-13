using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Ex.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public float Price { get; set; }

        public Guid? TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual TypeProduct? TypeProduct { get; set; }

        [Range(1, 10)]
        public float Rating { get; set; }

        public int NumberOfPurchases { get; set; }

        public string? ImagePath { get; set; }
    }
}
