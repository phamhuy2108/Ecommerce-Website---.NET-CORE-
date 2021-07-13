using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        [Required]
        public DateTime OrderedTime { get; set; }
        //[Required]
        //public Guid CreatorId { get; set; }
        public OrderItems OrderItems { get; set; }
    }
}
