using MyHR.Domain.Models;
using MyHR.Domain.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Modules
{
    public class BonusModule
    {
        private readonly BonusService _bonusService;
        //public List<Bonus> listaBonusuri = new List<Bonus>();

        public BonusModule ()
        {
            _bonusService = new BonusService();
        }

        /*
        public List<Bonus> GetBonuses()
        {
            DataSet set = _bonusService.GetBonus();
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int BonusId = Convert.ToInt32(set.Tables[0].Rows[i]["BonusId"].ToString());
                int EmployeeId = Convert.ToInt32(set.Tables[0].Rows[i]["EmployeeId"].ToString());
                String Name = set.Tables[0].Rows[i]["Name"].ToString();
                String Surname = set.Tables[0].Rows[i]["Surname"].ToString();
                DateTime StartDate = Convert.ToDateTime(set.Tables[0].Rows[i]["StartDate"].ToString());
                DateTime EndDate = Convert.ToDateTime(set.Tables[0].Rows[i]["EndDate"].ToString());
                Decimal BonusAmount = Convert.ToDecimal(set.Tables[0].Rows[i]["BonusAmount"].ToString());
                int SysCurrencyId = Convert.ToInt32(set.Tables[0].Rows[i]["SysCurrencyId"].ToString());
                string SysCurrencyName = Convert.ToString(set.Tables[0].Rows[i]["SysCurrencyName"].ToString());

                Bonus bonus = new Bonus(BonusId, EmployeeId, Name, Surname, StartDate, EndDate, BonusAmount, SysCurrencyId, SysCurrencyName);
                listaBonusuri.Add(bonus);
            }
            return listaBonusuri;
            */
        }

  }

