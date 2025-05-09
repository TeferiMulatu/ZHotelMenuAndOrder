using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZHotelMenuAndOrder.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        // Navigation Property
        public virtual Category Category { get; set; }
    }

}
