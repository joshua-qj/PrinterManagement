using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.DataAccess.SQL
{
    public class SQLDBContext : DbContext
    {
        public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<PrinterModel> Printers { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //        modelBuilder.Entity<PrinterModel>()
        //.HasKey(  Id = 1, PrinterName = "HP" );
        //    }
    }
}
