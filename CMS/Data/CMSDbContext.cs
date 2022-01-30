using CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options) : base(options)
        {

        }
        public DbSet<CMS.Models.Appointment> Appointment { get; set; }
        public DbSet<CMS.Models.Patient> Patient { get; set; }
        public DbSet<CMS.Models.Doctor> Doctor { get; set; }
    
    }

}
