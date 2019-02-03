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
    public class SalaryService:IDisposable
    {

        private readonly SqlConnection _sqlConnection;

        public SalaryService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            _sqlConnection = new SqlConnection(settings.ConnectionString);

            _sqlConnection.Open();
        }

        public DataSet InsertSalary(Salary salary)
        {
            try
            {
                SqlCommand comanda = new SqlCommand("exec uspInsertSalary @EmployeeId,@StartDate, @Amount, @CurrencyId", _sqlConnection);
                comanda.Parameters.AddWithValue("@EmployeeId", salary.IdSalariat);
                comanda.Parameters.AddWithValue("@StartDate", salary.StartDate);
                comanda.Parameters.AddWithValue("@Amount", salary.Amount);
                comanda.Parameters.AddWithValue("@CurrencyId", salary.IdValuta);
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
                sqlDataAdapter.Fill(ds);


                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InsertBonus(Bonus bonus )
        {
            try
            {
                SqlCommand comanda = new SqlCommand("exec uspInsertBonus @EmployeeId, @StartDate, @Amount, @CurrencyId", _sqlConnection);
                comanda.Parameters.AddWithValue("@EmployeeId", bonus.IdSalariat);
                comanda.Parameters.AddWithValue("@StartDate", bonus.StartDate);
                comanda.Parameters.AddWithValue("@Amount", bonus.BonusAmount);
                comanda.Parameters.AddWithValue("@CurrencyId", bonus.IdValuta);
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
                sqlDataAdapter.Fill(ds);


                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }

    }
}
