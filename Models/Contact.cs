using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZHotelMenuAndOrder.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress] // Validates email format
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        [Column(TypeName = "varchar(MAX)")]
        public string Message { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}