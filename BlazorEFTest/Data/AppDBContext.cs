using System;
using Microsoft.EntityFrameworkCore;

namespace BlazorEFTest.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
