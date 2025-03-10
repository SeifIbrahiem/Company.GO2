using Company.GO2.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.GO2.DAL.Data.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext(): base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = CompanyGO2; Trusted_Connection = True ; TrustedServerCertificate = True ");
        }
            public DbSet<Department> DepartmentSet { get; set; }
        public object Assemply { get; private set; }
    }
    }

