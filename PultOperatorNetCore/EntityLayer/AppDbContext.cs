using Microsoft.EntityFrameworkCore;
using PultOperatorNetCore.Model;
using PultOperatorNetCore.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.EntityLayer
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Turns> Turns { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<PositionService> PositionService { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CurrentTurn> CurrentTurn { get; set; }
        public DbSet<HistoryTurn> HistoryTurns { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // +StaticClass.IpAddress +
           /* string url = "server=" + StaticClass.IpAddress + ";user=root;password=123456;database=SystemElectron;";
            optionsBuilder.UseMySql(url,
                 new MySqlServerVersion(new Version(5, 7, 33))
             );*/
        }
    }
}
