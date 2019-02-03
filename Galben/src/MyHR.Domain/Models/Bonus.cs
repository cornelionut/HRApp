using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
    public class Bonus
    {
        int idBonus;
        int idSalariat;
        string numeSalariat;
        string prenumeSalariat;
        DateTime startDate;
        DateTime endDate;
        decimal bonusAmount;
        int idValuta;
        string numeValuta;


        public Bonus(int idBonus, int idSalariat, string numeSal, string prenumeSal, DateTime start, DateTime end, decimal bonusAmount, int idValuta, string Valuta)
        {
            this.idBonus = idBonus;
            this.idSalariat = idSalariat;
            this.numeSalariat = numeSal;
            this.prenumeSalariat = prenumeSal;
            this.startDate = start;
            this.endDate = end;
            this.bonusAmount = bonusAmount;
            this.idValuta = idValuta;
            this.numeValuta = Valuta;
        }
        public Bonus(int idSalariat,DateTime start, decimal bonusAmount, int idValuta)
        { 
            this.idSalariat = idSalariat;
            this.startDate = start;
            this.bonusAmount = bonusAmount;
            this.idValuta = idValuta;
            
        }

        public int IdBonus { get { return 5; } set => idBonus = value; }
        public int IdSalariat { get => idSalariat; set => idSalariat = value; }
        public string NumeSalariat { get => numeSalariat; set => numeSalariat = value; }
        public string PrenumeSalariat { get => prenumeSalariat; set => prenumeSalariat = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public decimal BonusAmount { get => bonusAmount; set => bonusAmount = value; }
        public int IdValuta { get => idValuta; set => idValuta = value; }
        public String NumeValuta { get => numeValuta; set => this.numeValuta = value; }
    }
}
