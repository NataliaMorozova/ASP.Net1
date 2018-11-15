using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>(3)
            {
                new EmployeeView(){id = 1, SurName="Иванов", FirstName="Иван", Patronymic = "Иванович", Age=23 },
                new EmployeeView(){id = 2, SurName="Петров", FirstName="Петр", Patronymic = "Петрович", Age=26},
                new EmployeeView(){id = 3, SurName="Сидоров", FirstName="Сергей", Patronymic = "Сергеевич", Age=25 }
            };
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.id == id);
        }

        public void AddNew(EmployeeView model)
        {
            model.id = _employees.Max(e => e.id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if(employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
