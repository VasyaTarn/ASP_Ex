using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace ASP_Ex.Models
{
    public class TypeProduct
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        [Range(1, 10)]
        public float Rating { get; set; }
    }
}
