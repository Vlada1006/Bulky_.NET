using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        [DisplayName("Car Name")]
        public string CarName { get; set; }
        [DisplayName("Car Color")]
        public string CarColor { get; set; }

    }
}
