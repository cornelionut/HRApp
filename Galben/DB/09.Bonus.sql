CREATE TABLE Bonus(
  BonusId int identity(0,1) primary key,
  EmployeeId int not null ,
  StartDate date,
  EndDate date ,
  BonusAmount decimal(8,3),
  CurrencyId int not null,
     CONSTRAINT [FK_Employee_Bonus] foreign key ([EmployeeId])references Employee ([EmployeeId]),
	 CONSTRAINT [FK_Currency_Bonus] foreign key ([CurrencyId])references SysCurrency ([SysCurrencyId])
);