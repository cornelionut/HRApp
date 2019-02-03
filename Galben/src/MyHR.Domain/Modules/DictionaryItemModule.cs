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
    public class DictionaryItemModule
    {
        

        private readonly DictionaryItemService _dictionaryItemService;



        public DictionaryItemModule()
        {
            _dictionaryItemService = new DictionaryItemService();
        }


        public List<DictionaryItem> ListState()
        {
            List<DictionaryItem> listState = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetState();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {

                int id = (int)set.Tables[0].Rows[i]["SysStateId"];
                string name = set.Tables[0].Rows[i]["SysStateName"].ToString();
                listState.Add(new DictionaryItem(id, name));

            }
            return listState;
        }

        public List<DictionaryItem> GetDepartment(int departmentId)
        {
            List<DictionaryItem> listState = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetDepartment(departmentId);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int id = (int)set.Tables[0].Rows[i]["SysStateId"];
                string name = set.Tables[0].Rows[i]["SysDepartmentName"].ToString();
                listState.Add(new DictionaryItem(id, name));

            }
            return listState;
        }


        public List<DictionaryItem> ListDepartment()
        {
            List<DictionaryItem> listDepartment = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetDepartment();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {

                int id = (int)set.Tables[0].Rows[i]["SysDepartmentId"];
                string name = set.Tables[0].Rows[i]["SysDepartmentName"].ToString();
                listDepartment.Add(new DictionaryItem(id, name));

            }
            return listDepartment;
        }

        public List<DictionaryItem> ListPosition()
        {
            List<DictionaryItem> listPosition = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetPosition();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {

                int id = (int)set.Tables[0].Rows[i]["SysPositionId"];
                string name = set.Tables[0].Rows[i]["SysPositionName"].ToString();
                listPosition.Add(new DictionaryItem(id, name));

            }
            return listPosition;
        }

        public List<DictionaryItem> ListCounty()
        {
            List<DictionaryItem> listCounty = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetCounty();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int id = (int)set.Tables[0].Rows[i]["SysCountyId"];
                string name = set.Tables[0].Rows[i]["SysCountyName"].ToString();
                listCounty.Add(new DictionaryItemCounty(id, name));

            }
            return listCounty;
        }

        public List<DictionaryItem> ListCity(int countyId)
        {
            List<DictionaryItem> listCity = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetCity(countyId);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {

                int id = (int)set.Tables[0].Rows[i]["SysCityId"];
                string name = set.Tables[0].Rows[i]["SysCityName"].ToString();
                int countyid = (int)set.Tables[0].Rows[i]["SysCountyId"];
                listCity.Add(new DictionaryItemCity(id, name,countyid));

            }
            return listCity;
        }

        public List<DictionaryItem> ListCurrency()
        {
            List<DictionaryItem> listCurrency = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetCurrency();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {

                int id = (int)set.Tables[0].Rows[i]["SysCurrencyId"];
                string name = set.Tables[0].Rows[i]["SysCurrencyName"].ToString();
                listCurrency.Add(new DictionaryItem(id, name));

            }
            return listCurrency;
        }

        public List<DictionaryItem> ListManager()
        {
            List<DictionaryItem> listCurrency = new List<DictionaryItem>();
            DataSet set = _dictionaryItemService.GetManager();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                int id = (int)set.Tables[0].Rows[i]["ManagerId"];
                string name = set.Tables[0].Rows[i]["Manager"].ToString();
                listCurrency.Add(new DictionaryItem(id, name));

            }
            return listCurrency;
        }

        public List<DictionaryItem> GetEmployees()
        { 
            return null;

        }
    }

}

