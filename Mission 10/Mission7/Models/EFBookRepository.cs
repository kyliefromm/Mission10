using System;
using System.Linq;
using Mission7.Models;
using Mission7.Models.ViewModels;

namespace Mission7.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookContext context { get; set; }

        public EFBookRepository(BookContext temp)
        {
            context = temp;
        }



        public IQueryable<Book> Books => context.Books;

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

    }
}


