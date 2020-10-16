using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sample01.controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            var obj = new {id=1 , name="Ish" };
            return View("Index",obj);
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Description()
        {
            return View("OtherView/Des.cshtml");
        }

        public ViewResult Description2()
        {
            return View("../../OtherView/Des");
        }
    }
}
