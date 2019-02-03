using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class Record
    {
        private string name;
        private string surname;
        private string pin;
        private string streetName;
        private int streetNo;
        private string stateName;
        private DateTime employmentDate;
        private string departmentName;
        private string positionName;
        public string adresa;
        public string manager;
        public string vechime;
        public decimal salariu;


        public Record(string name, string surname, string departmentName, string pin, string adresa, string manager, string vechime, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.departmentName = departmentName;
            this.pin = pin;
            this.adresa = adresa;
            this.manager = manager;
            this.vechime = vechime;
            this.salariu = salary;
        }

        public Record( string name)
        {
            this.Name = name;
        }
        public Record()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Manager { get => manager; set => manager = value; }
        public string Vechime { get => vechime; set => vechime = value; }
        public string StateName { get => stateName; set => stateName = value; }
        public string PositionName { get => positionName; set => positionName = value; }
        public decimal Salary { get => salariu; set => salariu = value; }
    }
}
