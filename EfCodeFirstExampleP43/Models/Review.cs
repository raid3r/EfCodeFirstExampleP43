using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Models;

public class Review
{
    public int Id { get; set; }
    public string? Comment { get; set; }
    public int Rating { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    public string Temp { get; set; }
}


//[Table("Reviews")]
//public class Review
//{
//    [Required]
//    [Key]
//    public int Id { get; set; }
//    [StringLength(500)]
//    [Column("Comment")]
//    public string? Comment { get; set; }
//    [Range(1, 5)]
//    public int Rating { get; set; }
//    public int ProductId { get; set; }
//    public virtual Product Product { get; set; }

//    //[Precision(18, 5)] - This attribute specifies that the Value property should be stored in the database with a precision of 18 and a scale of 5. This means that the total number of digits allowed is 18, with 5 digits allowed after the decimal point.
//    //public decimal Value { get; set; }

//    [NotMapped]
//    public string Temp { get; set; } // This property will be ignored by EF Core
//}
