using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Models;

public class Brand // table Brands
{
    public int Id { get; set; } // Id INT IDENTITY(1,1) PRIMARY KEY
    public string Name { get; set; } // Name NVARCHAR(MAX) NOT NULL
    public string? Country { get; set; } // Country NVARCHAR(MAX) NULL
    public decimal Rating { get; set; } // Rating DECIMAL(18,2) NOT NULL

    // New properties added 
    public string? ContactEmail { get; set; } // ContactEmail NVARCHAR(MAX) NULL

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
