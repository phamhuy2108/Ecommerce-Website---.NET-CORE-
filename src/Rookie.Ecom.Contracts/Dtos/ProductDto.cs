using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class ProductDto
    {
        public Guid ? ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Featured { get; set; }
        public string Images { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
