using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using MyHR.Domain.Models;
using MyHR.Domain.EFModel;
using System.Linq;

namespace MyHR.Domain.Services
{
    public class EmployeeService : IDisposable
    {
        private readonly SqlConnection _sqlConnection;
        private readonly DbContex _dbContex;

        public EmployeeService()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];

            _sqlConnection = new SqlConnection(settings.ConnectionString);

            _sqlConnection.Open();

            _dbContex = new DbContex();
        }

        public DataSet GetEmployeesCombo()
        {
            try
            {
                SqlCommand comanda = new SqlCommand("select EmployeeId, Name from Employee", _sqlConnection);

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
        //Gabi
        public DataSet GetEmployees()
        {
            try
            {
                SqlCommand comanda = new SqlCommand("select E.EmployeeId,E.Name, E.Surname, E.PIN, concat(CO.SysCountyName, ', ', C.SysCityName, ', Street ', EA.StreetName, ', no. ', EA.StreetNo) as 'Address', concat(EM.Name, ' ', EM.Surname) as 'Manager', S.SysStateName, concat( datediff(mm, E.EmploymentDate, getdate())/12,' years', ' ',datediff(mm, E.EmploymentDate, getdate())%12,' months') as 'Seniority', D.SysDepartmentName from Employee E left join Employee EM on EM.EmployeeId = E.ManagerId join SysState S on S.SysStateId = E.StateId join EmployeeAddress EA on EA.AddressId = E.AddressId join SySCity C on C.SysCityId = EA.SysCityId join SysCounty CO on CO.SysCountyId = C.SysCountyId join SysDepartment D on D.SysDepartmentId = E.DepartmentId ", _sqlConnection);

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
        public DataSet GetAllEmployees(int page = 1, int offset = 50, string name = null,
            int IdDepartment = -1)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "_spGetEmployee";

                SqlParameter pageParameter = new SqlParameter();
                pageParameter.ParameterName = "@Page";
                pageParameter.DbType = DbType.Int32;
                pageParameter.Direction = ParameterDirection.Input;
                pageParameter.Value = page;

                SqlParameter offSetParameter = new SqlParameter();
                offSetParameter.ParameterName = "@Offset";
                offSetParameter.DbType = DbType.Int32;
                offSetParameter.Direction = ParameterDirection.Input;
                offSetParameter.Value = offset;

                SqlParameter nameParameter = new SqlParameter();
                nameParameter.ParameterName = "@Name";
                nameParameter.DbType = DbType.String;
                nameParameter.Direction = ParameterDirection.Input;
                if (String.IsNullOrEmpty(name))
                {
                    nameParameter.Value = SqlString.Null;
                }
                else
                {
                    nameParameter.Value = name;
                }
                nameParameter.IsNullable = true;

                SqlParameter departamentIdParameter = new SqlParameter();
                departamentIdParameter.ParameterName = "@DepartmentId";
                departamentIdParameter.DbType = DbType.Int32;
                departamentIdParameter.Direction = ParameterDirection.Input;
                departamentIdParameter.Value = IdDepartment;

                sqlCommand.Parameters.Add(pageParameter);
                sqlCommand.Parameters.Add(nameParameter);
                sqlCommand.Parameters.Add(offSetParameter);
                sqlCommand.Parameters.Add(departamentIdParameter);

                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetNumberOfEmployees(string name = null, int departmentId = -1)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "_spEmployeesNo";

                SqlParameter nameParameter = new SqlParameter();
                nameParameter.ParameterName = "@Name";
                nameParameter.DbType = DbType.String;
                nameParameter.Direction = ParameterDirection.Input;
                if (String.IsNullOrEmpty(name))
                {
                    nameParameter.Value = SqlString.Null;
                }
                else
                {
                    nameParameter.Value = name;
                }
                nameParameter.IsNullable = true;

                SqlParameter departamentIdParameter = new SqlParameter();
                departamentIdParameter.ParameterName = "@DepartmentId";
                departamentIdParameter.DbType = DbType.Int32;
                departamentIdParameter.Direction = ParameterDirection.Input;
                departamentIdParameter.Value = departmentId;

                sqlCommand.Parameters.Add(nameParameter);
                sqlCommand.Parameters.Add(departamentIdParameter);

                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataSet);



                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Laur
        public DataSet GetEmployeeRecord(int id)
        {
            try
            {
                SqlCommand comanda = new SqlCommand("select E.Name ,E.Surname,E.PIN,concat('strada ',EA.StreetName, ' numarul ',EA.StreetNo,' oras ',sCI.SysCityName,' judet ',sCO.SysCountyName) as Adresa,EE.Name as Nume_Manager,EE.Surname as Prenume_Manager, sST.SysStateName, E.EmploymentDate, E.Picture, sPO.SysPositionName as Functie, sDE.SysDepartmentName, SA.Amount as Salariu from Employee E join EmployeeAddress EA on EA.AddressId = E.AddressId join SysCity sCI on sCI.SysCityId = EA.SysCityId join SysCounty sCO on sCI.SysCountyId = sco.SysCountyId LEFT join Employee EE on EE.EmployeeId = e.ManagerId join SysState sST on sST.SysStateId = E.StateId join SysPosition sPO on SysPositionId = E.PositionId join SysDepartment sDE on sDE.SysDepartmentId = E.DepartmentId join Salary SA on SA.EmployeeId = E.EmployeeId left join Salary SA2 on (SA.EmployeeId = SA2.EmployeeId and SA.SalaryId < SA2.SalaryId) where SA2.SalaryId is null and E.EmployeeId = @Id ");
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
                sqlDataAdapter.Fill(ds);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Id";
                parameter.DbType = DbType.Int32;
                parameter.Size = 4;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = id;
                comanda.Parameters.Add(parameter);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet GetManager(string DepName)
        {
            try
            {
                SqlCommand comanda = new SqlCommand("select concat(E.Name,' ', E.Surname) as 'NumeManager' from Employee E join SysDepartment D on D.SysDepartmentId = E.DepartmentId where D.SysDepartmentName = @DepName AND E.PositionId = 1");
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
                sqlDataAdapter.Fill(ds);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@DepName";
                parameter.DbType = DbType.String;
                parameter.Size = 200;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = DepName;
                comanda.Parameters.Add(parameter);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSalary()
        {
            SqlCommand comanda = new SqlCommand("select s.SalaryId,e.EmployeeId,e.Name,e.Surname,s.StartDate,s.EndDate,s.Amount,sCu.SysCurrencyId,sCu.SysCurrencyName from Salary s join Employee e on s.EmployeeId = e.EmployeeId join SysCurrency sCu on s.CurrencyId = sCu.SysCurrencyId");
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
            sqlDataAdapter.Fill(ds);
            return ds;
        }
        //Laur

        public DataSet GetBonus()
        {
            SqlCommand comanda = new SqlCommand("select b.BonusId,e.EmployeeId,e.Name,e.Surname,b.StartDate,b.EndDate,b.BonusAmount,sCu.SysCurrencyId,sCu.SysCurrencyName from Bonus b join Employee e on e.EmployeeId = b.EmployeeId join SysCurrency sCu on b.CurrencyId = sCu.SysCurrencyId");
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comanda);
            sqlDataAdapter.Fill(ds);
            return ds;
        }

        public List<string> SaveEmployee(EmployeeEditModel employeeEditModel)
        {
            List<string> errors = new List<string>();
            try
            {
                if (employeeEditModel.EmployeeId == 0)
                {
                    EmployeeAddress employeeAddress = new EmployeeAddress();
                    employeeAddress.SysCityId = employeeEditModel.CityId;
                    employeeAddress.StreetName = employeeEditModel.StreetName;
                    employeeAddress.StreetNo = employeeEditModel.StreetNo;

                    EFModel.Employee employee = new EFModel.Employee();
                    employee.EmployeeAddress = employeeAddress;
                    employee.DepartmentId = employeeEditModel.DepartmentId;
                    employee.EmploymentDate = employeeEditModel.EmploymentDate;
                    employee.ManagerId = employeeEditModel.ManagerId;
                    employee.Name = employeeEditModel.Name;
                    employee.Picture = employeeEditModel.Picture;
                    employee.PIN = employeeEditModel.PIN;
                    employee.PositionId = employeeEditModel.PositionId;
                    employee.StateId = employeeEditModel.StateId;
                    employee.Surname = employeeEditModel.Surname;

                    _dbContex.Employees.Add(employee);

                    _dbContex.SaveChanges();
                }
                else
                {
                    EFModel.Employee employee = _dbContex.Employees.Where(a => a.EmployeeId == employeeEditModel.EmployeeId).FirstOrDefault();

                    EmployeeHistory employeeHistory = new EmployeeHistory();
                    employeeHistory.DepartmentId = employee.DepartmentId;
                    employeeHistory.EmployeeId = employee.EmployeeId;
                    employeeHistory.EndDate = employee.EmploymentDate;
                    employeeHistory.StartDate = employee.ModifiedOn;
                    employeeHistory.StateId = employee.StateId;
                    employeeHistory.Surname = employee.Surname;
                    employeeHistory.Name = employee.Name;
                    employeeHistory.PIN = employee.PIN;
                    employeeHistory.ModifyDate = DateTime.Now;
                    employeeHistory.PositionId = employee.PositionId;
                    employeeHistory.ManagerId = (int?)(employee.ManagerId.HasValue ? (int?)employee.ManagerId : (int?)null);

                    //

                    employee.EmployeeAddress.SysCityId = employeeEditModel.CityId;
                    employee.EmployeeAddress.StreetName = employeeEditModel.StreetName;
                    employee.EmployeeAddress.StreetNo = employeeEditModel.StreetNo;
                    employee.DepartmentId = employeeEditModel.DepartmentId;
                    employee.EmploymentDate = employeeEditModel.EmploymentDate;
                    employee.ManagerId = employeeEditModel.ManagerId;
                    employee.Name = employeeEditModel.Name;
                    employee.Picture = employeeEditModel.Picture;
                    employee.PIN = employeeEditModel.PIN;
                    employee.PositionId = employeeEditModel.PositionId;
                    employee.StateId = employeeEditModel.StateId;
                    employee.Surname = employeeEditModel.Surname;
                    employee.ModifiedOn = DateTime.Now;

                    _dbContex.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
            }

            return errors;
        }

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }
    }
}
