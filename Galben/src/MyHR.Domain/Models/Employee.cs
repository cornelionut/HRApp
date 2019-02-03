using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyHR.Domain.Models
{
    [Table("Employee")]
    public class Employee
    {
        private int employeeId;
        private string name;
        private string surname;
        private string pin;
        private int streetNo;
        private string stateName;
        private DateTime employmentDate;
        private string departmentName;
        private string departmentId;
        private string positionName;
        public string adresa;

        private int sysCountyId;
        private int sysCityId;
        private int stateId;
        private int streetName;

        private int managerId;
        private string managerName;
        public string vechime;


        public Employee(int employeeId,string name, string surname,string departmentName, string pin, string adresa, string managerName, string vechime)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Surname = surname;
            this.departmentName = departmentName;
            this.pin = pin;
            this.adresa = adresa;
            this.managerName = managerName;
            this.vechime = vechime;
        }

        public Employee(int employeeId, string name)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
        }
        public Employee()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Vechime { get => vechime; set => vechime = value; }
        public int EmployeeId{ get => this.employeeId; set => this.employeeId = value; }
        public string StateName { get => stateName; set => stateName = value; }
        public string PositionName { get => positionName; set => positionName = value; }
        public DateTime EmploymentDate { get => employmentDate; set => employmentDate = value; }

        public int SysCountyId { get => sysCountyId; set => sysCountyId = value; }
        public int SysCityId { get => sysCityId; set => sysCityId = value; }
        public int StreetName { get => streetName; set => streetName = value; }
        public int StateId { get => stateId; set => stateId = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public int ManagerId { get => managerId; set => managerId = value; }
        public string ManagerName { get => managerName; set => managerName = value; }

        //public HttpPostedFileWrapper ImageFile { get; set; }
    }
}

