using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class ShoppingCart
    {
        [Key]
        [ForeignKey("AppUser")]
        public Guid UserId { get; set; }
        public double TotalMoney { get; set; }
        public virtual AppUser AppUser { get; set; }
        public ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
