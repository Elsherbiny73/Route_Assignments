using Microsoft.AspNetCore.Mvc;

namespace MVC_Session2.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello From Index Action";
        //}

        //public ActionResult Index()
        //{
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "Hello From Content Result";
            //return contentResult;

         //   return Content("Hello From Content");
        // }
        //public string AboutUs()
        //{
        //    return "Contact with Us using YouTube channel"; 
        //}
        //public ActionResult AboutUs() 
        //{
        //    return Redirect("https://codeforces.com/profile/EL__Sherbiny");
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
