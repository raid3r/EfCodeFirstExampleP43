// See https://aka.ms/new-console-template for more information
using EfCodeFirstExampleP43.Data;
using EfCodeFirstExampleP43.Models;


void SeedData()
{
    using (var context = new ComputerStoreDbContext())
    {
        var newTag = new Tag { Name = "New" };
        var popularTag = new Tag { Name = "Popular" };
        var saleTag = new Tag { Name = "Sale" };
        var discountTag = new Tag { Name = "Discount" };

        // Додати категорії
        var category1 = new Category { Name = "Processors" };
        var category2 = new Category { Name = "Graphics Cards" };
        var category3 = new Category { Name = "Memory" };

        context.Categories.AddRange(category1, category2, category3);

        // Бренди

        var brand1 = new Brand { Name = "Intel", Country = "USA", Rating = 4.5M };
        var brand2 = new Brand { Name = "AMD", Country = "USA", Rating = 4.3M };
        var brand3 = new Brand { Name = "NVIDIA", Country = "USA", Rating = 4.7M };
        var brand4 = new Brand { Name = "Corsair", Country = "USA", Rating = 4.4M };
        var brand5 = new Brand { Name = "G.Skill", Country = "Taiwan", Rating = 4.2M };

        // Додавання продуктів до таблиці Products

        var product1 = new Product
        {
            Name = "Intel Core i9-13900K",
            Price = 599.99m,
            Stock = 50,
            Category = category1,
            Brand = brand1,
            Tags = new List<Tag> { newTag, popularTag } // ProductTags 
        };
        var product2 = new Product
        {
            Name = "AMD Ryzen 9 7950X",
            Price = 549.99m,
            Stock = 40,
            Category = category1,
            Brand = brand2,
            Tags = new List<Tag> { popularTag, saleTag }
        };

        var product3 = new Product
        {
            Name = "NVIDIA GeForce RTX 4090",
            Price = 1499.99m,
            Stock = 20,
            Category = category2,
            Brand = brand3,
            Tags = new List<Tag> { newTag, discountTag }
        };

        var product4 = new Product
        {
            Name = "Corsair Vengeance LPX 16GB",
            Price = 89.99m,
            Stock = 100,
            Category = category3,
            Brand = brand4,
            Tags = new List<Tag> { saleTag, discountTag, popularTag }
        };

        var product5 = new Product
        {
            Name = "G.Skill Trident Z RGB 32GB",
            Price = 199.99m,
            Stock = 80,
            Category = category3,
            Brand = brand5,
            Tags = new List<Tag> { newTag, popularTag }
        };

        context.Products.AddRange(product1, product2, product3, product4, product5);

        context.SaveChanges();
    }

}


SeedData();






/*
 * 
 * Microsoft.EntityFrameworkCore.Tools
 * Microsoft.EntityFrameworkCore.SqlServer
 * Microsoft.EntityFrameworkCore.Tools
 * 
 * 
 * База даних товарів - комплектуючі для комп'ютерів
 * 
 * 
 * Товар
 * - назва
 * - категорія
 * - ціна
 * - кількість на складі
 * - виробник
 * 
 * +Категорія
 * - назва
 * 
 * Тег
 * - назва
 * 
 * Тег продукту
 * - який товар
 * - який тег
 * 
 * +Виробник
 * - назва
 * - країна
 * - рейтинг
 * 
 * Відгуки на товари
 * - текст відгуку
 * - дата відгуку   
 * - оцінка (1-5)
 * 
 * Продаж товару
 * - який товар
 * - кількість проданих одиниць
 * - по якій ціні продано
 * - дата продажу
 * 
 * 
 * 
 */


/*
            міграція
0   ------------------------------->       1          ------------------------------->         2
    <-------------------------------                  <--------------------------------                --------------------------------------------
Бази даних немає                 Створена база даних ComputerStoreP43             Створити таблиці Tags, ProductTags, Reviews, Sales
Таблиці не створені              Створені таблиці Categories, Brands, Products


Послідовність дій - міграція











1. Створюємо, або змінюємо класи моделей 
(наприклад, додали нову властивість ContactEmail до класу Brand)

2. Нові моделі додаємо до контексту бази даних ComputerStoreDbContext 
(наприклад, додали DbSet<Review> Reviews)

3. Створюємо міграцію, яка відображає зміни в моделях та контексті бази даних
(наприклад, команда Add-Migration AddContactEmailToBrand)

4. Застосовуємо міграцію до бази даних, щоб створити або змінити структуру бази даних відповідно до моделей
(наприклад, команда Update-Database)


// PROD
if (args.Length > 0 && args[0] == "prod")
{
    Console.WriteLine("Running in production mode.");
    // Production-specific code here

    // EnsureCreated - створює базу даних, якщо її ще немає,
    using (var context = new ComputerStoreDbContext())
    {
        context.Database.EnsureCreated();
    }
    Console.WriteLine("Database created successfully.");

}



*/

/*
 * Додати уточнення до моделей за допомогою Fluent API або Data Annotations (атрибути)
 * Довжина текттових полів, точність для числових полів, 
 * визначення інші назви таблиць та стовпців тощо
 * 
 * 
 */



