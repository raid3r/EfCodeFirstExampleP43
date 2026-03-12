using EfCodeFirstExampleP43.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExampleP43.Data;

public class ComputerStoreDbContext: DbContext
{
    public ComputerStoreDbContext()
    {
    }

    public ComputerStoreDbContext(DbContextOptions<ComputerStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=SILVERSTONE\\SQLEXPRESS;Initial Catalog=ComputerStoreP43; Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Fluent API configurations
        // Ігноруємо властивість Temp в класі Review, вона не буде відображатися в базі даних
        modelBuilder.Entity<Review>().Ignore(r => r.Temp);

        // Встановлюємо максимальну довжину для властивості
        // Comment в класі Review
        modelBuilder.Entity<Review>()
            .Property(r => r.Comment)
            .HasMaxLength(500);

        // Визначити назву таблиці для сутності Review
        modelBuilder.Entity<Review>().ToTable("Reviews");

        // Головний ключдля сутності Review
        modelBuilder.Entity<Review>()
            .HasKey(r => r.Id);

        // Зовнішній ключ та каскадне видалення між Review та Product
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Product)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        // ТОчність та масштаб для властивості Value в класі Review
        modelBuilder.Entity<Review>()
            .Property(r => r.Rating)
            .HasPrecision(18, 5);

        // назва колонки для властивості Comment в класі Review
        modelBuilder.Entity<Review>()
            .Property(r => r.Comment)
            .HasColumnName("Comment");

     
    }
}
