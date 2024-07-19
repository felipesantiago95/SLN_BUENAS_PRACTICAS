using Microsoft.AspNetCore.Mvc;
using SLN_BUENAS_PRACTICAS.Factories;
using SLN_BUENAS_PRACTICAS.Interfaces;
using SLN_BUENAS_PRACTICAS.Models;
using System;

namespace SLN_BUENAS_PRACTICAS.Controllers
{
    public class LibraryController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;

        public LibraryController(IBookRepository bookRepository, IUserRepository userRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }

        [HttpPost]
        public IActionResult AddBook(string title, string author, DateTime publishedDate)
        {
            var book = BookFactory.CreateBook(title, author, publishedDate);
            _bookRepository.AddBook(book);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddUser(string name, string email)
        {
            var user = UserFactory.CreateUser(name, email);
            _userRepository.AddUser(user);
            return RedirectToAction("Index");
        }
    }
}

