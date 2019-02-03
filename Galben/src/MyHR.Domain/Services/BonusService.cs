using MyHR.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHR.Domain.Services
{
    public class BonusService
    {
        private readonly SqlConnection _sqlConnection;

        public BonusService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            _sqlConnection = new SqlConnection(settings.ConnectionString);

            _sqlConnection.Open();
        }

        /*

        public DataSet GetBonus()
        {
            SqlCommand comanda = new SqlCommand("select b.BonusId,b.EmployeeId,e.Name,e.Surname,b.StartDate,b.EndDate,b.BonusAmount,b.CurrencyId,sc.SysCurrencyName from Bonus b join Employee e on e.EmployeeId = b.EmployeeId join SysCurrency sc on b.CurrencyId = sc.SysCurrencyId");
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
            sqlDataAdapter.Fill(ds);
            return ds;
        }
        */
        

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }
    }
}

