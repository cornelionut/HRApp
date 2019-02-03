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
    public class DictionaryCurrencyService : IDisposable   //By Gabriel
    {
        private readonly SqlConnection _sqlConnection;

        public DictionaryCurrencyService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            _sqlConnection = new SqlConnection(settings.ConnectionString);
            _sqlConnection.Open();
        }

        public DataSet GetCurrency()
        {
            try
            {
                SqlCommand comanda = new SqlCommand("", _sqlConnection);

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
