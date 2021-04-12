using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Data;
using BookStoreApp.Models;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {

        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public int AddNewBook(BookModel book)
        {
            var newBook = new Books()
            {
                Author = book.Author,
                CreatedOn = DateTime.UtcNow,
                Description = book.Description,
                Title = book.Title,
                TotalPages = book.TotalPages,
                UpdatedOn = DateTime.UtcNow
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();

            return newBook.Id;
        }

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Author = "Taushiq", Title="MVC", Description="This is a description for MVC Book!", Category="Programming", Language = "English", TotalPages= 163},
                new BookModel(){Id = 2, Author = "Taushiq", Title="Angular", Description="This is a description for Angular Book!", Category="Frontend Frameworks", Language = "English", TotalPages= 100},
                new BookModel(){Id = 3, Author = "Taushiq", Title="CSS", Description="This is a description for CSS Book!", Category="Frontend", Language = "English", TotalPages= 256},
                new BookModel(){Id = 4, Author = "Taushiq", Title="Python", Description="This is a description for Python Book!", Category="Backend", Language = "English", TotalPages= 354},
                new BookModel(){Id = 5, Author = "Taushiq", Title="Javascript", Description="This is a description for Javascript Book!", Category="Frontend", Language = "English", TotalPages= 567},
                new BookModel(){Id = 6, Author = "Nitish", Title="Azure DevOps", Description="This is a description for Azure DevOps Book!", Category="DevOps", Language = "English", TotalPages= 547}
            };
        }


    }
}
