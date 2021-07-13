using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class ProductRating
    {
        [Key]
        public Guid ProductRatingId { get; set; }
        //[Required]
        //public Guid CreatorId { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        public Product Product { get; set; }
    }
}
