using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStoreDomain;

namespace WebStore.Controllers
{
    [Route("users")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }
           
        /*
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
        */

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);

            if (ReferenceEquals(employee, null))
                return NotFound();

            return View(employee);
        }

        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }

        [Route("edit/{id?}")]
        [Authorize(Roles = WebStoreConstants.Roles.Admin)]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if(ReferenceEquals(model, null))
                return NotFound();
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        [Authorize(Roles = WebStoreConstants.Roles.Admin)]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Age < 18 || model.Age > 70)
            {
                ModelState.AddModelError("Age","Возраст должен быть от 18 до 70 лет");
            }

            if (ModelState.IsValid)
            {
                if (model.id > 0)
                {
                    var dbItem = _employeesData.GetById(model.id);
                    if (ReferenceEquals(dbItem, null))
                        return NotFound();

                    dbItem.SurName = model.SurName;
                    dbItem.FirstName = model.FirstName;
                    dbItem.Patronymic = model.Patronymic;
                    dbItem.Age = model.Age;
                }
                else
                {
                    _employeesData.AddNew(model);
                }

                return RedirectToAction(nameof(Index));
            }
            else
                return View(model);

        }

        [Route("delete/{id}")]
        [Authorize(Roles = WebStoreConstants.Roles.Admin)]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}