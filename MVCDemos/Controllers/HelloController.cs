using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemos.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "Hello";
        }
    }
}