// See https://aka.ms/new-console-template for more information
using EfCodeFirstExampleP43.Data;

Console.WriteLine("Hello, World!");


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



