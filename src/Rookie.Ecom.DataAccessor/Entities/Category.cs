using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
