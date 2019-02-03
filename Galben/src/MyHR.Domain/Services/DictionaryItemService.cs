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
    class DictionaryItemService:IDisposable
    {
        private readonly SqlConnection _sqlConnection;


        public DictionaryItemService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            _sqlConnection = new SqlConnection(settings.ConnectionString);
            _sqlConnection.Open();
        }

         public DataSet GetDepartment()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysDepartmentId, SysDepartmentName from SysDepartment";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        //aduce un departament anume dupa id
        public DataSet GetDepartment(int departmentId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysDepartmentId, SysDepartmentName from SysDepartment where SysDepartmentId=@departmentId";          
            command.Parameters.Add(new SqlParameter("@departmentId", departmentId));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        //Laur
        public DataSet GetState()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysStateId, SysStateName from SysState";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }
        //Laur
        public DataSet GetCurrency()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysCurrencyId, SysCurrencyName from SysCurrency";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        //Cornel
        public DataSet GetPosition()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysPositionId, SysPositionName from SysPosition";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        public DataSet GetCounty()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysCountyId, SysCountyName from SysCounty";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        public DataSet GetCity(int countyId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select SysCityId, SysCityName, SysCountyId from SysCity where SysCountyId = @countyId";
            command.Parameters.Add(new SqlParameter("@countyId", countyId));

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        public DataSet GetManager()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select distinct e.EmployeeId as 'ManagerId', concat(e.Name, ' ', e.Surname) as 'Manager' from Employee e join Employee ex on e.EmployeeId = ex.ManagerId";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            sqlDataAdapter.Fill(set);
            return set;
        }

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }
    }
}
