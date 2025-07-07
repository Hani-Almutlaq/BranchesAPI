using BranchesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BranchesAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
    }
}
