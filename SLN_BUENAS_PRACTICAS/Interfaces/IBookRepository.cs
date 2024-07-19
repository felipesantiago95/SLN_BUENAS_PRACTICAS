using System.Collections.Generic;
using SLN_BUENAS_PRACTICAS.Models;
namespace SLN_BUENAS_PRACTICAS.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(Guid id);
        void AddBook(Book book);
        void RemoveBook(Guid id);
    }
}
