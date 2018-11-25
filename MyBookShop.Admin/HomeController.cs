using MyBookShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyBookShop.Admin
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;

        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public ActionResult Index()
        {
            var book = _bookService.GetBook(1);

            return View();
        }
    }
}
