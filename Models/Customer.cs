using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApp.Models
{
    public class Customer
    {
        [Key] public int CustomerId { get; set; }
        [StringLength(150)] public string FullName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
