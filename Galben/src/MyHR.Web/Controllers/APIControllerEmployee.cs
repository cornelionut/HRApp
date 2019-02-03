using MyHR.Domain.Models;
using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyHR.Web.Controllers
{
    public class APIControllerEmployee : ApiController
    {
        private readonly EmployeeModule employeeModule;

        public APIControllerEmployee()
        {
            employeeModule = new EmployeeModule();
        }

        public IEnumerable<Employee> get()
        {
            List<Employee> employees = new List<Employee>();
            employees = employeeModule.GetEmployees();
            return employees;
        }
        /*
        public Employee get(int id)
        {
            
            Employee employee = employeeModule.GetEmployees(id);
            if (employee == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return employee;
            

        }
        */
    }
}
