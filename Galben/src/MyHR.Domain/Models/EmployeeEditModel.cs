using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class EmployeeEditModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }
        public int AddressId { get; set; }
        public int StateId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public byte[] Picture { get; set; }
        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int CityId { get; set; }
        public string StreetName { get; set; }
        public string StreetNo { get; set; }
    }
}
