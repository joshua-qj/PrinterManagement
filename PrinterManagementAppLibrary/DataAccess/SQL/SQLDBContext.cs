using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.DataAccess.SQL {
    public class SQLDBContext : DbContext {
        public DbSet<PrinterModel> Printers { get; set; }
        public DbSet<Site> Sites { get; set; }
        public SQLDBContext(DbContextOptions options) : base(options) {
            LoadCategories();
        }
        public void LoadCategories() {
            //    Site site = new Site() {
            //        Id = 1,
            //        Name = "GoldCoast",
            //        IconCSS = "fas fa-spa"
            //    };
            //    Sites.Add(site);
            //    site = new Site() {
            //        Id = 2,
            //        Name = "Cast",
            //        IconCSS = "fas fa-spa"
            //    };
            //    Sites.Add(site);

            //    site = new Site() {
            //        Id = 3,
            //        Name = "Brisbane",
            //        IconCSS = "fas fa-headphones"
            //    };
            //    Sites.Add(site);
            //    site = new Site() {
            //        Id = 4,
            //        Name = "Sydney",
            //        IconCSS = "fas fa-headphones"
            //    };
            //    Sites.Add(site);

            //    PrinterModel printer = new PrinterModel {
            //        Id = 199,
            //        IP = "8.8.8.8",
            //        Name = "STPMAN",
            //        Model = "E60165",
            //        MachineNo = "31258",
            //        SerialNo = "CNMRPCL5J8",
            //        Location = "SWT Parts Manager (Andrew)",
            //        Department = "Parts SWT",
            //        Manufacturer = "HP",
            //        SiteId = 1
            //    };
            //    Printers.Add(printer);
            //    printer = new PrinterModel {
            //        Id = 190,
            //        IP = "172.16.1.1",
            //        Name = "STPWAR",
            //        Model = "E60165",
            //        MachineNo = "31451",
            //        SerialNo = "CNMKM7P2KF",
            //        Location = " Clerk (Jack)",
            //        Department = "Service ",
            //        Manufacturer = "HP",
            //        SiteId = 1
            //    };
            //    Printers.Add(printer);

        }
    }
}
