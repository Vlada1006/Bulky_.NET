using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }

        [Required]
        [Display(Name ="List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 50+")]
        public double Price50 { get; set; }
        [Required]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set; }


    }
}
