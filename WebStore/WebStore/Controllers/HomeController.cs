using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {


        private readonly List<Models.EmployeeView> _employees = new List<Models.EmployeeView>
        {
            new Models.EmployeeView
            {
                id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 23
            },

            new Models.EmployeeView
            {
                id = 2,
                FirstName = "Петр",
                SurName = "Петров",
                Patronymic = "Петрович",
                Age = 32
            }
        };

        public IActionResult Details(int s_id)
        {
            return View(_employees.FirstOrDefault(e => e.id == s_id));
        }

        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}