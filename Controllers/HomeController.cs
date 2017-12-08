using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcHelloWorld.Models;

namespace MvcHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "Hello world...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
