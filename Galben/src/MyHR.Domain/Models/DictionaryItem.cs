using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class DictionaryItem
    {

        public int id;
        public string name;

        public DictionaryItem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }


    }

    public class DictionaryItemCity : DictionaryItem
    {
        private int _cityId;

        public DictionaryItemCity(int id, string name, int cityId) : base(id, name)
        {
            this.Id = id;
            this.Name = name;
            this.CityId = cityId;
        }

        public int CityId { get => _cityId; set => _cityId = value; }
    }

    public class DictionaryItemCounty : DictionaryItem
    {

        public DictionaryItemCounty(int id, string name) : base(id, name)
        {
            this.id = id;
        }


    }


    //public class DictionaryItemPosition : DictionaryItem
    //{
    //    public int _cityId;

    //    public DictionaryItemPosition(int id, string name, int cityId) : base(id, name)
    //    {
    //        _cityId = cityId;
    //    }
    //    public int cityId { get => cityId; set => cityId = value; }

    //}
}
