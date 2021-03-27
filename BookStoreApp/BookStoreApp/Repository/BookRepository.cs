﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Models;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {
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
                new BookModel(){Id = 1, Author = "Taushiq", Title="MVC"},
                new BookModel(){Id = 2, Author = "Taushiq", Title="Angular"},
                new BookModel(){Id = 3, Author = "Taushiq", Title="CSS"},
                new BookModel(){Id = 4, Author = "Taushiq", Title="Python"},
                new BookModel(){Id = 5, Author = "Taushiq", Title="Javascript"},
            };
        }


    }
}