using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHR.Domain.Services;
using MyHR.Domain.Models;
using System.Data;
using MyHR.Domain.ValueObjects;

namespace MyHR.Domain.Modules
{
    public class EmployeeModule
    {
        private readonly EmployeeService _employeeService;
        public List<Employee> listaAngajati = new List<Employee>();


        public EmployeeModule()
        {
            _employeeService = new EmployeeService();
        }

        public List<Employee> GetEmployees(int page = 1, int offset = 5,
            string name = null, int IdDepartment = -1)
        {
            DataSet set = _employeeService.GetAllEmployees();
            set = _employeeService.GetAllEmployees(page, offset, name, IdDepartment);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int EmployeeId = Convert.ToInt32(set.Tables[0].Rows[i]["EmployeeId"].ToString());
                string Surname = set.Tables[0].Rows[i]["Surname"].ToString();
                string Name = set.Tables[0].Rows[i]["Name"].ToString();
                string PIN = set.Tables[0].Rows[i]["PIN"].ToString();
                string Adresa = set.Tables[0].Rows[i]["Adresa"].ToString();
                string ManagerName = set.Tables[0].Rows[i]["Manager"].ToString();

                string Vechime = set.Tables[0].Rows[i]["Seniority"].ToString();
                string Department = set.Tables[0].Rows[i]["SysDepartmentName"].ToString();




                //Employee p = new Employee(EmployeeId, Name, Surname, PIN, Adresa, Manager, Vechime);
                Employee p = new Employee(EmployeeId, Name, Surname, Department, PIN, Adresa, ManagerName, Vechime);
                listaAngajati.Add(p);
            }

            return listaAngajati;

        }
        public int GetNumberOfEmployees(string name = null, int departmentId = -1)
        {
            DataSet dataSet = new DataSet();
            dataSet = _employeeService.GetNumberOfEmployees(name, departmentId);
            int numberOfEmployees = (int)dataSet.Tables[0].Rows[0]["NumberOfEmployees"];

            return numberOfEmployees;
        }
        public List<Employee> GetEmployeeCombo()
        {
            DataSet set = _employeeService.GetEmployeesCombo();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int EmployeeId = Convert.ToInt32(set.Tables[0].Rows[i]["EmployeeId"].ToString());
                string Name = set.Tables[0].Rows[i]["Name"].ToString();


                Employee p = new Employee(EmployeeId, Name);
                listaAngajati.Add(p);
            }

            return listaAngajati;

        }
        public List<Salary> GetSalaries()
        {
            DataSet set = _employeeService.GetSalary();
            List<Salary> listaSalarii = new List<Salary>();
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int SalaryId = Convert.ToInt32(set.Tables[0].Rows[i]["SalaryId"].ToString());
                int EmployeeId = Convert.ToInt32(set.Tables[0].Rows[i]["EmployeeId"].ToString());
                String Name = set.Tables[0].Rows[i]["Name"].ToString();
                String Surname = set.Tables[0].Rows[i]["Surname"].ToString();
                DateTime StartDate = Convert.ToDateTime(set.Tables[0].Rows[i]["StartDate"].ToString());
                DateTime EndDate = Convert.ToDateTime(set.Tables[0].Rows[i]["EndDate"].ToString());
                Decimal Amount = Convert.ToDecimal(set.Tables[0].Rows[i]["Amount"].ToString());
                int SysCurrencyId = Convert.ToInt32(set.Tables[0].Rows[i]["SysCurrencyId"].ToString());
                string SysCurrencyName = Convert.ToString(set.Tables[0].Rows[i]["SysCurrencyName"].ToString());
                Salary salary = new Salary(SalaryId, EmployeeId, Name, Surname, StartDate, EndDate, Amount, SysCurrencyId, SysCurrencyName);
                listaSalarii.Add(salary);
            }
            return listaSalarii;
        }

        public List<Bonus> GetBonuses()
        {
            DataSet set = _employeeService.GetBonus();
            List<Bonus> listaBonusuri = new List<Bonus>();
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int BonusId = Convert.ToInt32(set.Tables[0].Rows[i]["BonusId"].ToString());
                int EmployeeId = Convert.ToInt32(set.Tables[0].Rows[i]["EmployeeId"].ToString());
                String Name = set.Tables[0].Rows[i]["Name"].ToString();
                String Surname = set.Tables[0].Rows[i]["Surname"].ToString();
                DateTime StartDate = Convert.ToDateTime(set.Tables[0].Rows[i]["StartDate"].ToString());
                DateTime EndDate = Convert.ToDateTime(set.Tables[0].Rows[i]["EndDate"].ToString());
                Decimal BonusAmount = Convert.ToDecimal(set.Tables[0].Rows[i]["BonusAmount"].ToString());
                int SysCurrencyId = Convert.ToInt32(set.Tables[0].Rows[i]["SysCurrencyId"].ToString());
                string SysCurrencyName = Convert.ToString(set.Tables[0].Rows[i]["SysCurrencyName"].ToString());

                Bonus bonus = new Bonus(BonusId, EmployeeId, Name, Surname, StartDate, EndDate, BonusAmount, SysCurrencyId, SysCurrencyName);
                listaBonusuri.Add(bonus);
            }
            return listaBonusuri;
        }

        public List<string> SaveEmployee(EmployeeEditModel employeeEditModel)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(employeeEditModel.Name))
                errors.Add("Campul Numele nu poate fi gol");
            if (string.IsNullOrWhiteSpace(employeeEditModel.Surname))
                errors.Add("CampulPrenumele nu poate fi gol");
            if (string.IsNullOrWhiteSpace(employeeEditModel.PIN))
                errors.Add("Campul CNP nu poate fi gol");
            if (string.IsNullOrWhiteSpace(employeeEditModel.StreetName))
                errors.Add("Campul Strada nu poate fi gol");
            if (string.IsNullOrWhiteSpace(employeeEditModel.StreetNo))
                errors.Add("Campul Nr Strada nu poate fi gol");
            if (employeeEditModel.StateId == 0)
                errors.Add("Campul Stare nu poate fi gol");
            if (employeeEditModel.DepartmentId == 0)
                errors.Add("Campul Stare nu poate fi gol");
            if (employeeEditModel.PositionId == 0)
                errors.Add("Campul Stare nu poate fi gol");

            if (employeeEditModel.PositionId != (int)SysPositionEnum.CEO)
                if (employeeEditModel.ManagerId == 0)
                    errors.Add("Campul Manager nu poate fi gol");

            if (!errors.Any())
                errors.AddRange(_employeeService.SaveEmployee(employeeEditModel));

            return errors;
        }

    }
}
