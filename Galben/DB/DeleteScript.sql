if exists(select 1 from sysobjects where name='Bonus' and xtype='U')
drop table Bonus

go

if exists(select 1 from sysobjects where name='Salary' and xtype='U')
drop table Salary

go

if exists(select 1 from sysobjects where name='EmployeeHistory' and xtype='U')
drop table EmployeeHistory

go

if exists(select 1 from sysobjects where name='Employee' and xtype='U')
drop table Employee

go

if exists(select 1 from sysobjects where name='SysCurrency' and xtype='U')
drop table SysCurrency

go

if exists(select 1 from sysobjects where name='SysPosition' and xtype='U')
drop table SysPosition

go

if exists(select 1 from sysobjects where name='SysDepartment' and xtype='U')
drop table SysDepartment

go

if exists(select 1 from sysobjects where name='EmployeeAddress' and xtype='U')
drop table EmployeeAddress

go

if exists(select 1 from sysobjects where name='SysCity' and xtype='U')
drop table SysCity

go


if exists(select 1 from sysobjects where name='SysCounty' and xtype='U')
drop table SysCounty

go

if exists(select 1 from sysobjects where name='SysState' and xtype='U')
drop table SysState

go