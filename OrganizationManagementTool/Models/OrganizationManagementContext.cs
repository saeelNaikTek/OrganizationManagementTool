using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Models
{
    public class OrganizationManagementContext : DbContext
    {
        public OrganizationManagementContext(DbContextOptions<OrganizationManagementContext> options):base(options)
        {

        }

        public DbSet<FacultyModel> FacultyTbl { get; set; }
        public DbSet<DepartmentsModel> DepartmentTbl { get; set; }
    }
}
