using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Featured { get; set; }
        [Required]
        public string Images { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductRating> ProductRatings { get; set; }
        public ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
