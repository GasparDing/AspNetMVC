using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // The following two aciton will reture string 
        // you can specific the type you want to return.
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "This is my <b>default</b> action";
        //}

        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int num = 1)
        {
            // Security Note: The code above uses HttpUtility.HtmlEncode
            // to protect the application from malicious input (namely JavaScript)
            return HttpUtility.HtmlEncode("Hello " + name + ",num is " + num);
        }
    }
}