using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Models;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Country { get; set; }
    public decimal Rating { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
