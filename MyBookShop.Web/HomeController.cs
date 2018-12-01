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
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Conact(ConactViewModel conactView)
        {
            if (ModelState.IsValid)
            {

            }
            return View(conactView);
        }
    }
}
