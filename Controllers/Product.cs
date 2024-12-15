using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication4.Controllers
{
    public class Product
    {
        [Key]
        [JsonIgnore]
        public int PId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(0,100,ErrorMessage ="Price should be from 0 to 100")]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
