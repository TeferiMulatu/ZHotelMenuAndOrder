using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZHotelMenuAndOrder.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        // Navigation Property
        public virtual ICollection<Product> Products { get; set; }
    }
}



