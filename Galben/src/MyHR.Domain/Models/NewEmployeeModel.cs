using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class NewEmployeeModel:Employee
    {
            private int? _addressId;
            private int? cityId;
            private int? countyId;
            private string streetName;
            private string streetNo;

        public int? AddressId { get => _addressId; set => _addressId = value; }
        public int? CityId { get => cityId; set => cityId = value; }
        public int? CountyId { get => countyId; set => countyId = value; }
        public string StreetName1 { get => streetName; set => streetName = value; }
        public string StreetNo { get => streetNo; set => streetNo = value; }
    }
}
