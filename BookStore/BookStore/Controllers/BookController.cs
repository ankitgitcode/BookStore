using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetAllBooks()
        {
            return "All books";
        }

        public string GetBook(string id)
        {
            if (id == null)
            {
                return "No book found";
            }
            else
            return $"book {id}";
        }
    }
}
