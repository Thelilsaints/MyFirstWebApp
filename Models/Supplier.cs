using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApp.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = null!;

        public string? ContactEmail { get; set; }
        public string? Phone { get; set; }

        [InverseProperty("Supplier")]
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
