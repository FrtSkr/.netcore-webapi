using System.ComponentModel.DataAnnotations;

namespace webapi_challenge.Models
{
    public class Boat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String color { get; set; }
        [Required]
        public String brand { get; set; }
        [Required]
        public String model { get; set; }
        [Required]
        public bool anchor { get; set; }
    }
}
