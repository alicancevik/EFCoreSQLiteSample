using EFCoreSQLiteSample.DAL;
using EFCoreSQLiteSample.Entities;
using System;
using System.Linq;

namespace EFCoreSQLiteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EFCoreSQLiteSample...");

            using (var context = new AppDbContext())
            {
                // GetAll Books
                var books = context.Books.ToList();

                books.ForEach(x => { Console.WriteLine(x.Title); });


                // Add Book 
                
                context.Add(new Book { Title = "Book 1", Isbn = "1234" , CreatedDate = DateTime.Now });
                context.SaveChanges();
            }

            Console.WriteLine("Completed.");
        }
    }
}
