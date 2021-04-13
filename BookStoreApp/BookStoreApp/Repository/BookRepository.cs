using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {

        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel book)
        {
            var newBook = new Books()
            {
                Author = book.Author,
                CreatedOn = DateTime.UtcNow,
                Description = book.Description,
                Title = book.Title,
                LanguageId = book.LanguageId,
                TotalPages = book.TotalPages.HasValue ? book.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow
            };

           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            var allbooks = new List<BookModel>();
            var books = await _context.Books.ToListAsync();

            if(books?.Any() == true)
            {
                   foreach (var book in books)
                {
                    allbooks.Add(
                        new BookModel()
                        {
                            Author = book.Author,
                            Category = book.Category,
                            Title = book.Title,
                            TotalPages = book.TotalPages,
                            Description = book.Description,
                            Id = book.Id,
                            LanguageId = book.LanguageId,
                            //Language = book.Language.Name
                        }
                        ) ;
                }
            }

            return allbooks;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            // return DataSource().Where(x => x.Id == id).FirstOrDefault();

            return await _context.Books.Where(x => x.Id == id).Select(
                book => new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Title = book.Title,
                    TotalPages = book.TotalPages,
                    Description = book.Description,
                    Id = book.Id,
                    LanguageId = book.LanguageId,
                    Language = book.Language.Name
                }
                
                ).FirstOrDefaultAsync();

            
          
           
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }

        


    }
}
