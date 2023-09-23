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
                Name = "STPMAN",
                Model = "E60165",
                MachineNo = "31258",
                SerialNo = "CNMRPCL5J8",
                Location = "SWT Parts Manager (Andrew)",
                Department = "Parts SWT",
                Manufacturer = "HP",
                SiteId = 1
            };
            db.Printers.Add(printer);
            printer = new PrinterModel {
                Id = 2,
                IP = "172.16.1.1",
                Name = "STPWAR",
                Model = "E60165",
                MachineNo = "31451",
                SerialNo = "CNMKM7P2KF",
                Location = " Clerk (Jack)",
                Department = "Service ",
                Manufacturer = "HP",
                SiteId = 1
            };
            db.Printers.Add(printer);
             printer = new PrinterModel {
                Id = 3,
                IP = "127.0.0.1",
                Name = "STADMIN2",
                Model = "E60165",
                MachineNo = "31450",
                SerialNo = "CNMKMB3W",
                Location = "Accounts Pay Mazda (Hei)",
                Department = "Admin",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 4,
                IP = "172.16.1.120",
                Name = "PAY",
                Model = "E6016",
                MachineNo = "3147",
                SerialNo = "CNMKM69ZV",
                Location = "Accounts Pay (Sarah)",
                Department = "Admin",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);
            printer = new PrinterModel {
                Id = 5,
                IP = "8.8.8.8",
                Name = "ACC",
                Model = "E6065",
                MachineNo = "3146",
                SerialNo = "CNMRCL540",
                Location = "Accounts Rec (Lor)",
                Department = "Admin",
                Manufacturer = "HP",
                SiteId = 3
            };

            printer = new PrinterModel {
                Id = 6,
                IP = "6.6.6.6",
                Name = "STVEHRO",
                Model = "E6015",
                MachineNo = "3166",
                SerialNo = "CNMPCL5JT",
                Location = "Clerk (Jik)",
                Department = "New Cars ",
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
                Location = "Developer (Ji)",
                Department = "New",
                Manufacturer = "HP",
                SiteId = 4
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 8,
                IP = "7.7.7.7",
                Name = "PA",
                Model = "E606",
                MachineNo = "31477",
                SerialNo = "79ZV",
                Location = "rahu",
                Department = "Ad",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);


            printer = new PrinterModel {
                Id =9 ,
                IP = "8.8.8.8",
                Name = "AY",
                Model = "16",
                MachineNo = "37",
                SerialNo = "CNM",
                Location = "Acc",
                Department = "Admin",
                Manufacturer = "HP",
                SiteId = 2
            };
            db.Printers.Add(printer);

            printer = new PrinterModel {
                Id = 10,
                IP = "9.9.9.9",
                Name = "APAY",
                Model = "E776016",
                MachineNo = "3177747",
                SerialNo = "C77ZV",
                Location = "Pay (7)",
                Department = "Adn",
                Manufacturer = "HP",
                SiteId = 3
            };
            db.Printers.Add(printer);
            db.SaveChanges();
        }
    }
}


