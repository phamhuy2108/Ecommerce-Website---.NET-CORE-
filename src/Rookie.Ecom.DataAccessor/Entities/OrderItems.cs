using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class OrderItems
    {
		[Key]
		public Guid OrderItemId { get; set; }
		[Required]
		public Guid OrderId { get; set; }
		[Required]
		public Guid ProductId { get; set; }
		[Required]
		public double Price { get; set; }
		[Required]
		public int Quantity { get; set; }
		public ICollection<Order> Orders { get; set; }
	}
}
