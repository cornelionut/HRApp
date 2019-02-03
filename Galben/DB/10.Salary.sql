create table Salary( 
  SalaryId int IDENTITY(0,1) primary key,
  EmployeeId int Not Null,
  StartDate date,
  EndDate date ,
  Amount decimal(8,3) Not Null,
  CurrencyId int Not Null,
     CONSTRAINT [FK_Employee_Salary] foreign key ([EmployeeId])references Employee ([EmployeeId]),
	 CONSTRAINT [FK_Currency_Salary] foreign key ([CurrencyId])references SysCurrency ([SysCurrencyId])
);