using SLN_BUENAS_PRACTICAS.Interfaces;
using SLN_BUENAS_PRACTICAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SLN_BUENAS_PRACTICAS.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(Guid id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Guid id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
