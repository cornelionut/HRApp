namespace MyHR.Domain.EFModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContex : DbContext
    {
        public DbContex()
            : base("name=DbContex")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Bonu> Bonus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SysCity> SysCities { get; set; }
        public virtual DbSet<SysCounty> SysCounties { get; set; }
        public virtual DbSet<SysCurrency> SysCurrencies { get; set; }
        public virtual DbSet<SysDepartment> SysDepartments { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SysPosition> SysPositions { get; set; }
        public virtual DbSet<SysState> SysStates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Bonu>()
                .Property(e => e.BonusAmount)
                .HasPrecision(8, 3);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Bonus)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee1)
                .WithOptional(e => e.Employee2)
                .HasForeignKey(e => e.ManagerId);

            modelBuilder.Entity<EmployeeAddress>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.EmployeeAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Salary>()
                .Property(e => e.Amount)
                .HasPrecision(8, 3);

            modelBuilder.Entity<SysCity>()
                .HasMany(e => e.EmployeeAddresses)
                .WithRequired(e => e.SysCity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysCounty>()
                .HasMany(e => e.SysCities)
                .WithRequired(e => e.SysCounty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysCurrency>()
                .HasMany(e => e.Bonus)
                .WithRequired(e => e.SysCurrency)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysCurrency>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.SysCurrency)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysDepartment>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.SysDepartment)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysPosition>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.SysPosition)
                .HasForeignKey(e => e.PositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SysState>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.SysState)
                .HasForeignKey(e => e.StateId)
                .WillCascadeOnDelete(false);
        }
    }
}
