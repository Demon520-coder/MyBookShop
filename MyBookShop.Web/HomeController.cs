using AutoMapper;
using DapperExtensions;
using MyBookShop.Models;
using MyBookShop.Service.Interface;
using MyBookShop.Service.Sorts;
using MyBookShop.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyBookShop.Web
{
    public class HomeController : Controller
    {
        private readonly ICustomerMessageService _customerMessageService;
        private readonly IBookService _bookService;
        private readonly ICartService _cartService;

        public HomeController(ICustomerMessageService customerMessageService, IBookService bookService
            , ICartService cartService)
        {
            this._customerMessageService = customerMessageService;
            this._bookService = bookService;
            this._cartService = cartService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Conact()
        {
            //获取留言信息:
            _cartService.Add(new Cart { BookId = 1, Nums = 1 });
            var list = _customerMessageService.GetAll();
            var book = _bookService.GetBook(1);
            var message = _customerMessageService.GetMessage(1);
            var result = _customerMessageService.GetList(new { IsDeleted = false });

            IList<ISort> sorts = new List<ISort>
            {
                new CustomerMessageSort
                {
                    PropertyName=nameof(CustomerMessage.CreateTime),
                    Ascending=false
                }
            };

            //var list = _customerMessageService.GetPageList(new { IsDeleted = true }, sorts, 1, 1).ToList();


            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Conact(ConactViewModel conactView)
        {
            if (ModelState.IsValid)
            {
                var message = Mapper.Map<ConactViewModel, CustomerMessage>(conactView);
                _customerMessageService.Add(message);

                return RedirectToAction("Index", "Home");
            }

            return View(conactView);
        }
    }
}
