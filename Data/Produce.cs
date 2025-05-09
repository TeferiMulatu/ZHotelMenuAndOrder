using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZHotelMenuAndOrder.Data
{
    [Table("Product")]
    public class Produce
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
