﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sample01.controllers
{
    public class HomeController:Controller
    {
        public String Index() {

            return "hii welcome?";
        }
    }
}