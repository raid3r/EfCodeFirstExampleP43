using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Models;

// Many-to-Many relationship between Product and Tag
// Tag *----* ProductTag  -- Product 
// ProductId, TagId      

public class Tag
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } // New, Popular, Sale, Discount, etc.
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
