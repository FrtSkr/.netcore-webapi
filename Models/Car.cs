using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using webapi_challenge.Models;

namespace webapi_challenge.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String color { get; set; }
        [Required]
        public String brand { get; set; }
        [Required]
        public String model { get; set; }
        [Required]
        public String wheels { get; set; }
        [Required]
        public String headlights { get; set; }
        [Required]
        public bool isHeadlightsOpen { get; set; }
    }

}
