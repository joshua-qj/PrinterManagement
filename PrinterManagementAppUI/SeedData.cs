using PrinterManagementAppLibrary.DataAccess.SQL;
using PrinterManagementAppLibrary.Models;
using System;
using System.Reflection;

namespace PrinterManagementAppUI {
    public static class SeedData {
        public static void AddInMemoryData(WebApplication app) {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<SQLDBContext>();
            Site site = new Site() {
                Id = 1,
                Name = "GoldCoast",
                IconCSS = "fas fa-spa"
            };
            db.Sites.Add(site);
            site = new Site() {
                Id = 2,
                Name = "Cleveland",
                IconCSS = "fas fa-spa"
            };
            db.Sites.Add(site);

            site = new Site() {
                Id = 3,
                Name = "Brisbane",
                IconCSS = "fas fa-headphones"
            };
            db.Sites.Add(site);
            site = new Site() {
                Id = 4,
                Name = "Sydney",
                IconCSS = "fas fa-headphones"
            };
            db.Sites.Add(site);

            PrinterModel printer = new PrinterModel {
                Id = 1,
                IP = "8.8.8.8",
                Name = "Microsoft",
                Model = "p60165",
                MachineNo = "31258",
                SerialNo = "CNMCL5J8",
                Location = "Bill Gates",
                Department = "arts ",
                Manufacturer = "HP",
                SiteId = 1
            };
            db.Printers.Add(printer);
            printer = new PrinterModel {
                Id = 2,
                IP = "172.16.1.1",
                Name = "Facebook",
                Model = "E6065",
                MachineNo = "3151",
                SerialNo = "CNMKM7KF",
                Location = " Mark Zuckerberg",
                Department = "Service ",
                Manufacturer = "HP",
                SiteId = 1
            };
            db.Printers.Add(printer);
             printer = new PrinterModel {
                Id = 3,
                IP = "127.0.0.1",
                Name = "NVIDIA",
                Model = "E6016",
                MachineNo = "3450",
                SerialNo = "CNMB3W",
                Location = "Jensen Huang",
                Department = "Huang",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 4,
                IP = "172.16.1.120",
                Name = "Amazon",
                Model = "E60",
                MachineNo = "317",
                SerialNo = "CNMK9ZV",
                Location = "Jeff Bezos",
                Department = "Amazon",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);
            printer = new PrinterModel {
                Id = 5,
                IP = "8.8.8.8",
                Name = "apple",
                Model = "E6065",
                MachineNo = "3146",
                SerialNo = "CNMRCL540",
                Location = "apple",
                Department = "apple",
                Manufacturer = "HP",
                SiteId = 3
            };

            printer = new PrinterModel {
                Id = 6,
                IP = "6.6.6.6",
                Name = "google",
                Model = "E6015",
                MachineNo = "3166",
                SerialNo = "Larry Page",
                Location = "google",
                Department = "google",
                Manufacturer = "HP",
                SiteId = 3
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 7,
                IP = "127.0.0.1",
                Name = "HERO",
                Model = "E6015",
                MachineNo = "31df66",
                SerialNo = "CNMPCssL5JT",
                Location = "HERO",
                Department = "New",
                Manufacturer = "HP",
                SiteId = 4
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 8,
                IP = "7.7.7.7",
                Name = "Linux ",
                Model = "E606",
                MachineNo = "31477",
                SerialNo = "79ZV",
                Location = "Linus Torvalds",
                Department = "Ad",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);


            printer = new PrinterModel {
                Id =9 ,
                IP = "8.8.8.8",
                Name = "IBM",
                Model = "16",
                MachineNo = "37",
                SerialNo = "CNM",
                Location = "IBM",
                Department = "IBM",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 10,
                IP = "9.9.9.9",
                Name = "APPLE",
                Model = "E776016",
                MachineNo = "3177747",
                SerialNo = "C77ZV",
                Location = "Tim Cook",
                Department = "APPLE",
                Manufacturer = "HP",
                SiteId = 3
            };
            db.Printers.Add(printer);
            db.SaveChanges();
        }
    }
}


