using MyHR.Domain.Models;
using MyHR.Domain.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Modules
{
    public class SalaryModule
    {

        public void ModuleInsertSalary(int id,DateTime date,decimal amount ,int currency)
        {

            SalaryService ss = new SalaryService();
            Salary salary = new Salary(id, date, amount, currency);
            DataSet set = ss.InsertSalary(salary);
        }

        public void ModuleInsertBonus(int id, DateTime date, decimal amount, int currency)
        {
            SalaryService ss = new SalaryService();
            Bonus bonus = new Bonus(id, date, amount, currency);
            DataSet set = ss.InsertBonus(bonus);

        }
    }
}
