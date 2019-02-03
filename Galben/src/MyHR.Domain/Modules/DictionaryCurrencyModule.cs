using MyHR.Domain.Models;
using MyHR.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Modules
{
    public class DictionaryCurrencyModule
    {
        private readonly DictionaryCurrencyService _dictionaryCurrencyService;  //By Gabriel

        public DictionaryCurrencyModule()
        {
            _dictionaryCurrencyService = new DictionaryCurrencyService();
        }

        public List<DictionaryCurrencyModule> GetCurrency()
        {
            return null;
        }
    }
}
