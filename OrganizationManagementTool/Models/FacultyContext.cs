using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Models
{
    public class FacultyContext : DbContext
    {
        public FacultyContext(DbContextOptions<FacultyContext> options):base(options)
        {

        }

        public DbSet<Faculty> Faculty_Tbl { get; set; }
        public DbSet<Departments> Department_Tbl { get; set; }
    }
}
