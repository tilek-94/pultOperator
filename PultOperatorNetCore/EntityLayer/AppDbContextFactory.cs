using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using PultOperatorNetCore.ViewModel.Classes;

namespace PultOperatorNetCore.EntityLayer
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args = null)
        {
            DbContextOptionsBuilder<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>();
            string url = "server=" + StaticClass.IpAddress + ";user=admin;password=123456;database=SystemElectron;";
            options.UseMySql(url);

            return new AppDbContext(options.Options);
        }

    }
}
