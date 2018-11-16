﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            //throw new InvalidOperationException("Ошибка");
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }



        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}