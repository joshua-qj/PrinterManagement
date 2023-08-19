using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.DataAccess.SQL {
    public class SQLDBContext : DbContext {
        public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options) {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<PrinterModel> Printers { get; set; }
        public DbSet<Site> Sites { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {     //Add Product Categories
            modelBuilder.Entity<Site>().HasData(new Site {
                Id = 1,
                Name = "Springwood",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Site>().HasData(new Site {
                Id = 2,
                Name = "Cleveland",
                IconCSS = "fa-solid fa-couch"
            });
            modelBuilder.Entity<Site>().HasData(new Site {
                Id = 3,
                Name = "Redlands",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<Site>().HasData(new Site {
                Id =4 ,
                Name = "Kingston",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<PrinterModel>().HasData(

      new PrinterModel {

          Id = 199,
          IP = "8.8.8.8",
          Name = "STPMAN",
          Model = "E60165",
          MachineNo = "31258",
          SerialNo = "CNMRPCL5J8",
          Location = "SWT Parts Manager (Andrew)",
          Department = "Parts SWT",
          Manufacturer = "HP",
          SiteId = 1
      },
       new PrinterModel {
           Id = 190,
           IP = "172.16.1.118",
           Name = "STPWAR",
           Model = "E60165",
           MachineNo = "31451",
           SerialNo = "CNMKM7P2KF",
           Location = " Clerk (Jack)",
           Department = "Service ",
           Manufacturer = "HP",
           SiteId = 1
       },
              new PrinterModel {
                  Id = 192,
                  IP = "172.16.1.119",
                  Name = "STADMIN2",
                  Model = "E60165",
                  MachineNo = "31450",
                  SerialNo = "CNMKMB3W",
                  Location = "Accounts Pay Mazda (Hei)",
                  Department = "Admin",
                  Manufacturer = "HP",
                  SiteId = 2
              },
                     new PrinterModel {
                         Id = 3,
                         IP = "172.16.1.120",
                         Name = "PAY",
                         Model = "E6016",
                         MachineNo = "3147",
                         SerialNo = "CNMKM69ZV",
                         Location = "Accounts Pay (Sarah)",
                         Department = "Admin",
                         Manufacturer = "HP",
                         SiteId = 2
                     },
                  new PrinterModel {
                      Id = 4,
                      IP = "172.16.1.121",
                      Name = "ACC",
                      Model = "E6065",
                      MachineNo = "3146",
                      SerialNo = "CNMRCL540",
                      Location = "Accounts Rec (Lor)",
                      Department = "Admin",
                      Manufacturer = "HP",
                      SiteId = 3
                  },
                   new PrinterModel {
                       Id = 5,
                       IP = "172.16.1.122",
                       Name = "STVEHRO",
                       Model = "E6015",
                       MachineNo = "3166",
                       SerialNo = "CNMPCL5JT",
                       Location = "Clerk (Jik)",
                       Department = "New Cars ",
                       Manufacturer = "HP",
                       SiteId = 3

                   },
                   new PrinterModel {
                       Id = 6,
                       IP = "127.0.0.1",
                       Name = "HERO",
                       Model = "E6015",
                       MachineNo = "31df66",
                       SerialNo = "CNMPCssL5JT",
                       Location = "Developer (Ji)",
                       Department = "New",
                       Manufacturer = "HP",
                       SiteId = 4

                   }
      );
        }
    }
}
