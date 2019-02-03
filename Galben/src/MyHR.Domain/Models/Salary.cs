using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Models
{
   public class Salary
    {
        //laur//
        int idSalariu;
        int idSalariat;
        string numeSalariat;
        string prenumeSalariat;
        DateTime startDate;
        DateTime endDate;
        decimal amount;
        int idValuta;
        string numeValuta;


        public Salary(int idSalariu,int idSalariat,string numeSal,string prenumeSal,DateTime start,DateTime end, decimal amount,int idValuta,string Valuta)
        {
            this.idSalariu = idSalariu;
            this.idSalariat = idSalariat;
            this.numeSalariat = numeSal;
            this.prenumeSalariat = prenumeSal;
            this.startDate = start;
            this.endDate = end;
            this.amount = amount;
            this.idValuta = idValuta;
            this.numeValuta = Valuta;
        }

        public Salary(int idSalariat,DateTime start, decimal amount, int idValuta)
        {
            this.idSalariu = idSalariat;
            this.idSalariat = idSalariat;
            this.startDate = start;
            this.amount = amount;
            this.idValuta = idValuta;
           
        }
        public int IdSalariu { get => idSalariu; set => idSalariu = value; }
        public int IdSalariat { get => idSalariat; set => idSalariat = value; }
        public string NumeSalariat { get => numeSalariat; set => numeSalariat = value; }
        public string PrenumeSalariat { get => prenumeSalariat; set => prenumeSalariat = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public  decimal Amount  { get => amount; set => amount = value; }
        public int IdValuta  { get => idValuta; set =>  idValuta = value; }
        public String NumeValuta  { get => numeValuta; set => this.numeValuta = value; }
    }
}
