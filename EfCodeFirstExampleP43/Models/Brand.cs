using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Models;

[Table("MyBrands")]
public class Brand // table Brands
{
    public int Id { get; set; } // Id INT IDENTITY(1,1) PRIMARY KEY
    [StringLength(100)]
    public string Name { get; set; } // Name NVARCHAR(MAX) NOT NULL
    [StringLength(100)]
    public string? Country { get; set; } // Country NVARCHAR(MAX) NULL
    [Precision(18, 2)]
    public decimal Rating { get; set; } // Rating DECIMAL(18,2) NOT NULL

    // New properties added 
    [StringLength(100)]
    public string? ContactEmail { get; set; } // ContactEmail NVARCHAR(MAX) NULL

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
