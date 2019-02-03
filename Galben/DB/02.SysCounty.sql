Create Table SysCity(
  SysCityId int Primary Key,
  SysCityName nvarchar(200),
  SysCountyId int not null,
      FOREIGN KEY (SysCountyId) REFERENCES SysCounty(SysCountyId)
);