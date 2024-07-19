using SLN_BUENAS_PRACTICAS.Models;
using System;

namespace SLN_BUENAS_PRACTICAS.Factories
{
    public static class BookFactory
    {
        public static Book CreateBook(string title, string author, DateTime publishedDate)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = title,
                Author = author,
                PublishedDate = publishedDate
            };
        }
    }
}
