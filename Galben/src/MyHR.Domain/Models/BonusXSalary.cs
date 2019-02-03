using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class BonusXSalary
    {
        int id;
        int idEmployee;
        DateTime startDate;
        decimal amount;
        int idCurrency;

        public BonusXSalary(int id, int idE,DateTime date,decimal amount,int idC)
        {
            this.id = id;
            this.idEmployee = idE;
            startDate = date;
            this.amount = amount;
            this.idCurrency = idC;
        }

        public BonusXSalary()
        {
            
        }
        public int Id { get => id; set => id = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public int IdCurrency { get => idCurrency; set => idCurrency = value; }
    }
}
