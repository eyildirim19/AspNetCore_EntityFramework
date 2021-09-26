using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_EntityFramework.Models
{
    public class CoreDBContext : DbContext
    {
        // base sınıfa connectionstring buradan gönderilmez..DbContextOptions tipinde generic bir paramertre tanımlanır. Base sınıfa bu parametre gönderilir. ctor'daki parametre ise Startup dosyasındanki ConfigurationServies metodundan gönderilir ...
        public CoreDBContext(DbContextOptions<CoreDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Product { get; set; }
    }
}
