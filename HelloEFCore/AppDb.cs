using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEFCore
{
    public class AppDb : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public string ConnectionString { get; }

        public AppDb()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var pathApp = Path.Combine(folder.ToString(), "HelloEFCore");
            if (!Directory.Exists(pathApp)) {
                Directory.CreateDirectory(pathApp);
            }
            ConnectionString = Path.Combine(pathApp, "HelloApp.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ConnectionString}");
        }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
