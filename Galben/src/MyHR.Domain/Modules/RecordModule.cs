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
    public class RecordModule
    {
        private readonly EmployeeService _employeeService;
        public List<Record> listaFisa = new List<Record>();

        public List<Record> GetEmployees(int id = 1)
        {
            DataSet set = _employeeService.GetEmployeeRecord(id);
            set = _employeeService.GetEmployeeRecord(id);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                string Surname = set.Tables[0].Rows[i]["Surname"].ToString();
                string Name = set.Tables[0].Rows[i]["Name"].ToString();
                string PIN = set.Tables[0].Rows[i]["PIN"].ToString();
                string Adresa = set.Tables[0].Rows[i]["Adresa"].ToString();
                string Manager = set.Tables[0].Rows[i]["Manager"].ToString();
                string Vechime = set.Tables[0].Rows[i]["Seniority"].ToString();
                string Department = set.Tables[0].Rows[i]["SysDepartmentName"].ToString();
                string Functie = set.Tables[0].Rows[i]["Position"].ToString();
                string DataAngajare = set.Tables[0].Rows[i]["EmploymentDate"].ToString();
                decimal Salariu = Decimal.Parse(set.Tables[0].Rows[i]["Salary"].ToString());

                //Employee p = new Employee(EmployeeId, Name, Surname, PIN, Adresa, Manager, Vechime);
                Record r = new Record(Name, Surname, Department, PIN, Adresa, Manager, Vechime, Salariu);
                listaFisa.Add(r);
            }

            return listaFisa;
        }
    }
}
