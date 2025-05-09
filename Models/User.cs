using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ZHotelMenuAndOrder.Models;

namespace ZHotelMenuAndOrder.Models
{
    [Index(nameof(Username), IsUnique = true)]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        //[Index(IsUnique = true)] // Creates unique constraint
        public string Username { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Address { get; set; } // varchar(max) maps to string without length

        [StringLength(50)]
        public string PostCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public string ImageUrl { get; set; } // varchar(max) maps to string without length

        [Required]
        public DateTime CreatedDate { get; set; }

        // Navigation property for Cart relationship
        public virtual ICollection<Cart> Carts { get; set; }
    }
}