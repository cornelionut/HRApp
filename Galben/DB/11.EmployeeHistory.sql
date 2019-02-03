create table EmployeeHistory (
   EmployeeHistoryId int IDENTITY(0,1) primary key,
   EmployeeId int Not Null,
   Name NVARCHAR(100),
   Surname NVARCHAR(100),
   PIN NVARCHAR(13),
   PositionId int Not Null,
   DepartmentId int Not Null,
   StartDate date Not Null,
   EndDate date Not Null,
   StateId int not null,
   ManagerId int not null,
   ModifyById NVARCHAR(128),
   ModifyDate date,
      CONSTRAINT [FK_History_Employee] foreign key ([EmployeeId])references Employee ([EmployeeId]),
      CONSTRAINT [FK_History_Position] foreign key ([PositionId])references SysPosition ([SysPositionId]),
	  CONSTRAINT [FK_History_User] foreign key ([ModifyById]) references AspNetUsers(Id)
);