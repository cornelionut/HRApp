create table EmployeeAddress(
  AddressId int NOT NULL IDENTITY(0,1) Primary Key,
  SysCityId int not null,
  StreetName nvarchar(256),
  StreetNo  nvarchar(50),
      Foreign Key (SysCityId) references SysCity(SysCityId)
);