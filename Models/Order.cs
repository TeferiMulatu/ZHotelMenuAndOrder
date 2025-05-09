using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ZHotelMenuAndOrder.Models;

namespace ZHotelMenuAndOrder.Models
{
    [Index(nameof(OrderNo), IsUnique = true)]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailsId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        // [Index(IsUnique = true)] // Unique constraint for OrderNo
        public string OrderNo { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        // public virtual Payment Payment { get; set; }
    }
}