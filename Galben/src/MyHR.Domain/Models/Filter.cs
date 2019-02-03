using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class Filter
    {

        private string _name;
        private int _idDepartment;

        public Filter()
        {
        }

        public Filter(string name, int idDepartment)
        {
            Name = name;
            IdDepartment = idDepartment;
        }
        public string Name { get => _name; set => _name = value; }
        public int IdDepartment { get => _idDepartment; set => _idDepartment = value; }
    }
}
