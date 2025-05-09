using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZHotelMenuAndOrder.Models;

namespace ZHotelMenuAndOrder.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}