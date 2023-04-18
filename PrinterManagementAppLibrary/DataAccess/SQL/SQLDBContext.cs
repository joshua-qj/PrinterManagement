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


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PrinterModel>().HasData(
      new PrinterModel {
          
         Id=199, IP = "172.16.1.117",
          Name = "STPMAN",
          Model = "E60165",
          MachineNo = "31258",
          SerialNo = "CNMRPCL5J8",
          Location = "SWT Parts Manager (Andrew)",
          Department = "Parts SWT",
          Manufacturer = "HP",
          Site = GlobalConfig.SpringwoodToyota
      },
       new PrinterModel {
          Id=190,
         IP = "172.16.1.118",
           Name = "STPWAR",
           Model = "E60165",
           MachineNo = "31451",
           SerialNo = "CNMKM7P2KF",
           Location = "SWT Warranty Clerk (Sharina)",
           Department = "Service SWT",
           Manufacturer = "HP",
           Site = GlobalConfig.SpringwoodToyota
       },
              new PrinterModel {
                Id=192, 
                  IP = "172.16.1.119",
                  Name = "STADMIN2",
                  Model = "E60165",
                  MachineNo = "31450",
                  SerialNo = "CNMKM6RB3W",
                  Location = "\tAccounts Pay Mazda (Heidi)",
                  Department = "Admin  SWT",
                  Manufacturer = "HP",
                  Site = GlobalConfig.SpringwoodToyota
              },
                     new PrinterModel {
                       Id=3,
                         IP = "172.16.1.120",
                         Name = "ACCPAY",
                         Model = "E60165",
                         MachineNo = "31447",
                         SerialNo = "CNMKM6R9ZV",
                         Location = "SWT Accounts Pay (Sarah)",
                         Department = "Admin",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },
                  new PrinterModel {
                    Id=4,
                      IP = "172.16.1.121",
                      Name = "ACCREC",
                      Model = "E60165",
                      MachineNo = "31469",
                      SerialNo = "CNMRPCL540",
                      Location = "SWT Accounts Rec (Lorraine)",
                      Department = "Admin",
                      Manufacturer = "HP",
                      Site = GlobalConfig.SpringwoodToyota
                  },
                   new PrinterModel {
                     Id=5, IP = "172.16.1.122",
                       Name = "STVEHPRO",
                       Model = "E60165",
                       MachineNo = "31466",
                       SerialNo = "CNMRPCL5JT",
                       Location = "SWT Admin Clerk 1 (Jiki)",
                       Department = "New Cars SWT",
                       Manufacturer = "HP",
                       Site = GlobalConfig.SpringwoodToyota

                   },
                                          new PrinterModel {
                                            Id=6, IP = "172.16.1.123",
                                              Name = "STFLEET2",
                                              Model = "E60165",
                                              MachineNo = "31463",
                                              SerialNo = "CNMRPCL5K4",
                                              Location = "SWT Vehicle Processing (Nick)",
                                              Department = "New Cars SWT",
                                              Manufacturer = "HP",
                                              Site = GlobalConfig.SpringwoodToyota
                                          },
                                                 new PrinterModel {
                                                   Id=7, IP = "172.16.1.124",
                                                     Name = "STFMAN",
                                                     Model = "E60165",
                                                     MachineNo = "31464",
                                                     SerialNo = "CNMRPCL5KN",
                                                     Location = "SWT Fleet Manager (Ben)",
                                                     Department = "New Cars SWT",
                                                     Manufacturer = "HP",
                                                     Site = GlobalConfig.SpringwoodToyota
                                                 },
                               new PrinterModel {
                                 Id=8, IP = "172.16.1.125",
                                   Name = "STSTOCK2",
                                   Model = "E60165",
                                   MachineNo = "31468",
                                   SerialNo = "CNMRPCL5L1",
                                   Location = "SWT Stock Control 2 (Rebecca)",
                                   Department = "New Cars SWT",
                                   Manufacturer = "HP",
                                   Site = GlobalConfig.SpringwoodToyota
                               },
                                   new PrinterModel {
                                     Id=9, IP = "172.16.1.127",
                                       Name = "HRMAN",
                                       Model = "E60165",
                                       MachineNo = "31465",
                                       SerialNo = "CNMRPCL5M1",
                                       Location = "HR Manager (Kathy)",
                                       Department = "Admin",
                                       Manufacturer = "HP",
                                       Site = GlobalConfig.SpringwoodToyota
                                   },
                                       new PrinterModel {
                                         Id=10, IP = "172.16.1.128",
                                           Name = "STOM",
                                           Model = "E60165",
                                           MachineNo = "31467",
                                           SerialNo = "CNMRPCL5MM",
                                           Location = "SWT Admin Manager (Fiona)",
                                           Department = "Admin",
                                           Manufacturer = "HP",
                                           Site = GlobalConfig.SpringwoodToyota
                                       },
                                       new PrinterModel {
                                         Id=11, IP = "172.16.1.129",
                                           Name = "STACC2",
                                           Model = "E55040",
                                           MachineNo = "31457",
                                           SerialNo = "JPBRP8F323",
                                           Location = "SWT Group Financial Controller (Greig)",
                                           Department = "Admin",
                                           Manufacturer = "HP",
                                           Site = GlobalConfig.SpringwoodToyota
                                       },
                                        new PrinterModel {
                                          Id=12, IP = "172.16.1.130",
                                            Name = "STUSEDCOLOUR",
                                            Model = "E55040",
                                            MachineNo = "31460",
                                            SerialNo = "JPBRP8F329",
                                            Location = "SWT Used Cars Manager (Steve)",
                                            Department = "Used Cars SWT",
                                            Manufacturer = "HP",
                                            Site = GlobalConfig.SpringwoodToyota
                                        },

                                       new PrinterModel {
                                         Id=13, IP = "172.16.1.134",
                                           Name = "STSCANNER",
                                           Model = "8500FN2",
                                           MachineNo = "???",
                                           SerialNo = "CN7B713024",
                                           Location = "SWT Admin (Scanner)",
                                           Department = "Service SWT",
                                           Manufacturer = "HP",
                                           Site = GlobalConfig.SpringwoodToyota
                                       },

                                        new PrinterModel {
                                          Id=14, IP = "172.16.1.137",
                                            Name = "SMOFFMAN",
                                            Model = "E60165",
                                            MachineNo = "31470",
                                            SerialNo = "CNMRPCL5N5",
                                            Location = "SWM Office Clerk (Cassie)",
                                            Department = "Admin Mazda",
                                            Manufacturer = "HP",
                                            Site = GlobalConfig.SpringwoodToyota
                                        },

                                            new PrinterModel {
                                              Id=15, IP = "172.16.1.138",
                                                Name = "STFLEETBM",
                                                Model = "E60165",
                                                MachineNo = "31486",
                                                SerialNo = "CNMRPCL4SN",
                                                Location = "SWT Fleet BM (Kristy)",
                                                Department = "Service SWT",
                                                Manufacturer = "HP",
                                                Site = GlobalConfig.SpringwoodToyota
                                            },

                                              new PrinterModel {
                                                Id=16, IP = "172.16.1.140",
                                                  Name = "STFLEET3",
                                                  Model = "E60165",
                                                  MachineNo = "31483",
                                                  SerialNo = "CNMRPCL4T6",
                                                  Location = "SWT Fleet Manager (Daniel)",
                                                  Department = "Fleet SWT",
                                                  Manufacturer = "HP",
                                                  Site = GlobalConfig.SpringwoodToyota
                                              },

                                              new PrinterModel {
                                                Id=17, IP = "172.16.1.141",
                                                  Name = "SWPAY",
                                                  Model = "E60165",
                                                  MachineNo = "31484",
                                                  SerialNo = "CNMRPCL5Y5",
                                                  Location = "SWT Payroll (Sarah)",
                                                  Department = "Admin",
                                                  Manufacturer = "HP",
                                                  Site = GlobalConfig.SpringwoodToyota
                                              },

                                                    new PrinterModel {
                                                      Id=18, IP = "172.16.1.142",
                                                        Name = "STSAM",
                                                        Model = "E60165",
                                                        MachineNo = "31485",
                                                        SerialNo = "CNMRPCL6CM",
                                                        Location = "SWT Service (Sumeshan)",
                                                        Department = "Service SWT",
                                                        Manufacturer = "HP",
                                                        Site = GlobalConfig.SpringwoodToyota
                                                    },

                                              new PrinterModel {
                                                Id=19, IP = "172.16.1.143",
                                                  Name = "STRECEPTION2",
                                                  Model = "E77822",
                                                  MachineNo = "31636",
                                                  SerialNo = "CND1N64020",
                                                  Location = "ST Reception 2",
                                                  Department = "Finance SWT",
                                                  Manufacturer = "Oki",
                                                  Site = GlobalConfig.SpringwoodToyota
                                              },

                                                 new PrinterModel {
                                                   Id=20, IP = "172.16.1.144",
                                                     Name = "STACOPIER",
                                                     Model = "E77830",
                                                     MachineNo = "22938",
                                                     SerialNo = "CNB8K7R26G",
                                                     Location = "SWT Admin (1st Floor)",
                                                     Department = "Admin  SWT",
                                                     Manufacturer = "HP",
                                                     Site = GlobalConfig.SpringwoodToyota
                                                 },

                                                    new PrinterModel {
                                                      Id=21, IP = "172.16.1.145",
                                                        Name = "STUTECH",
                                                        Model = "E60155",
                                                        MachineNo = "31482",
                                                        SerialNo = "CNMRPCL6DJ",
                                                        Location = "SWT Used Cars Service (Mark)",
                                                        Department = "Used Cars SWT",
                                                        Manufacturer = "HP",
                                                        Site = GlobalConfig.SpringwoodToyota
                                                    },

                                                         new PrinterModel {
                                                           Id=22, IP = "172.16.1.146",
                                                             Name = "STWSALE",
                                                             Model = "E60155",
                                                             MachineNo = "31496",
                                                             SerialNo = "CNMRPCL6B7",
                                                             Location = "SWT Used Cars (Billy)",
                                                             Department = "Used Cars SWT",
                                                             Manufacturer = "HP",
                                                             Site = GlobalConfig.SpringwoodToyota
                                                         },

                                                            new PrinterModel {
                                                              Id=23, IP = "172.16.1.147",
                                                                Name = "IT",
                                                                Model = "E60165",
                                                                MachineNo = "31487",
                                                                SerialNo = "CNMRPCL6C8",
                                                                Location = "IT Dept (Craig)",
                                                                Department = "Admin  SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                                                           new PrinterModel {
                                                             Id=24, IP = "172.16.1.148",
                                                               Name = "ITCOPIER",
                                                               Model = "E78325",
                                                               MachineNo = "31422",
                                                               SerialNo = "CNB1P3Q1CQ",
                                                               Location = "IT Dept (Craig)",
                                                               Department = "Admin  SWT",
                                                               Manufacturer = "HP",
                                                               Site = GlobalConfig.SpringwoodToyota
                                                           },

                                                             new PrinterModel {
                                                               Id=25, IP = "172.16.1.149",
                                                                 Name = "STRECEPTION",
                                                                 Model = "E77830",
                                                                 MachineNo = "22936",
                                                                 SerialNo = "CNB8K7R26M",
                                                                 Location = "SWT New Cars",
                                                                 Department = "New Cars SWT",
                                                                 Manufacturer = "HP",
                                                                 Site = GlobalConfig.SpringwoodToyota
                                                             },

                                                                new PrinterModel {
                                                                  Id=26, IP = "172.16.1.150",
                                                                    Name = "FINCON",
                                                                    Model = "E55040",
                                                                    MachineNo = "31461",
                                                                    SerialNo = "JPBRP8F33W",
                                                                    Location = "SWT Group CFO (Richard)",
                                                                    Department = "Admin",
                                                                    Manufacturer = "HP",
                                                                    Site = GlobalConfig.SpringwoodToyota
                                                                },

                                                                new PrinterModel {
                                                                  Id=27, IP = "172.16.1.151",
                                                                    Name = "STBM2COPIER",
                                                                    Model = "E77830",
                                                                    MachineNo = "22939",
                                                                    SerialNo = "CNB8K7R26W",
                                                                    Location = "SWT Finance Business Manager 2 (Jillian)",
                                                                    Department = "Finance SWT",
                                                                    Manufacturer = "HP",
                                                                    Site = GlobalConfig.SpringwoodToyota
                                                                },

                                                                 new PrinterModel {
                                                                   Id=28, IP = "172.16.1.152",
                                                                     Name = "STPCOPIER",
                                                                     Model = "E87650",
                                                                     MachineNo = "31640",
                                                                     SerialNo = "CNB8K2S0LB",
                                                                     Location = "SWT Parts Warehouse",
                                                                     Department = "Parts SWT",
                                                                     Manufacturer = "Oki",
                                                                     Site = GlobalConfig.SpringwoodToyota
                                                                 },

                                                                 new PrinterModel {
                                                                   Id=29, IP = "172.16.1.153",
                                                                     Name = "STSCOPIER",
                                                                     Model = "E77822",
                                                                     MachineNo = "31637",
                                                                     SerialNo = "CND1N64023",
                                                                     Location = "SWT Service (David)",
                                                                     Department = "Service SWT",
                                                                     Manufacturer = "HP",
                                                                     Site = GlobalConfig.SpringwoodToyota
                                                                 },

                                                                 new PrinterModel {
                                                                   Id=30, IP = "172.16.1.154",
                                                                     Name = "STUSEDCOPIER",
                                                                     Model = "E77822",
                                                                     MachineNo = "31638",
                                                                     SerialNo = "CND1N6702Q",
                                                                     Location = "SWT Used Cars (Steve)",
                                                                     Department = "Used Cars SWT",
                                                                     Manufacturer = "Oki",
                                                                     Site = GlobalConfig.SpringwoodToyota
                                                                 },

                                                                 new PrinterModel {
                                                                   Id=31, IP = "172.16.1.155",
                                                                     Name = "STBM1COPIER",
                                                                     Model = "E78330",
                                                                     MachineNo = "31629",
                                                                     SerialNo = "CNB1P960G1",
                                                                     Location = "SWT Finance Business Manager 1 (Sarah)",
                                                                     Department = "Finance SWT",
                                                                     Manufacturer = "Oki",
                                                                     Site = GlobalConfig.SpringwoodToyota
                                                                 },

                                                             new PrinterModel {
                                                               Id=32, IP = "172.16.1.156",
                                                                 Name = "STFXDOPCOPIER",
                                                                 Model = "E78330",
                                                                 MachineNo = "31631",
                                                                 SerialNo = "CNB1P960G2",
                                                                 Location = "SWT Fixed Operation Office (David)",
                                                                 Department = "Admin  SWT",
                                                                 Manufacturer = "Oki",
                                                                 Site = GlobalConfig.SpringwoodToyota
                                                             },


                                                              new PrinterModel {
                                                                Id=33, IP = "172.16.1.157",
                                                                  Name = "STFLEET",
                                                                  Model = "E60165",
                                                                  MachineNo = "31497",
                                                                  SerialNo = "CNMRPCL68G",
                                                                  Location = "SWT Fleet 1 (Chris)",
                                                                  Department = "Fleet  SWT",
                                                                  Manufacturer = "HP",
                                                                  Site = GlobalConfig.SpringwoodToyota
                                                              },

                                                                new PrinterModel {
                                                                  Id=34, IP = "172.16.1.159",
                                                                    Name = "STACC3",
                                                                    Model = "E55040",
                                                                    MachineNo = "31458",
                                                                    SerialNo = "JPBRP8F31N",
                                                                    Location = "SWT Accountant (Vineel)",
                                                                    Department = "Admin",
                                                                    Manufacturer = "HP",
                                                                    Site = GlobalConfig.SpringwoodToyota
                                                                },
                                                            new PrinterModel {
                                                              Id=35, IP = "172.16.1.160",
                                                                Name = "STSRO",
                                                                Model = "E60165",
                                                                MachineNo = "31500",
                                                                SerialNo = "CNMRPCL699",
                                                                Location = "SWT Service R/Orders (Craig)",
                                                                Department = "Service SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                                                            new PrinterModel {
                                                              Id=36, IP = "172.16.1.161",
                                                                Name = "STPARTS",
                                                                Model = "E60165",
                                                                MachineNo = "31501",
                                                                SerialNo = "CNMRPCL68P",
                                                                Location = "SWT Parts Warehouse (Middle)",
                                                                Department = "Parts SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                                                            new PrinterModel {
                                                              Id=37, IP = "172.16.1.162",
                                                                Name = "STSINV",
                                                                Model = "E60165",
                                                                MachineNo = "31499",
                                                                SerialNo = "CNMRPCL624",
                                                                Location = "SWT Service Invoice (Kiara)",
                                                                Department = "Service SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                                                            new PrinterModel {
                                                              Id=38, IP = "172.16.1.163",
                                                                Name = "STNEW",
                                                                Model = "E60165",
                                                                MachineNo = "31498",
                                                                SerialNo = "CNMRPCL6D4",
                                                                Location = "SWT New Cars",
                                                                Department = "New Cars SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                                                            new PrinterModel {
                                                              Id=39, IP = "172.16.1.164",
                                                                Name = "STPINV",
                                                                Model = "E60165",
                                                                MachineNo = "31503",
                                                                SerialNo = "CNMRPCL67F",
                                                                Location = "SWT Parts Ph Room (Brandon)",
                                                                Department = "Parts SWT",
                                                                Manufacturer = "HP",
                                                                Site = GlobalConfig.SpringwoodToyota
                                                            },

                     new PrinterModel {
                       Id=40, IP = "172.16.1.165",
                         Name = "STUSED",
                         Model = "E60165",
                         MachineNo = "31502",
                         SerialNo = "CNMRPCL6BJ",
                         Location = "SWT Used Cars (Jason)",
                         Department = "Used Cars SWT",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=41, IP = "172.16.1.166",
                         Name = "PAYCOPYA3",
                         Model = "E78325",
                         MachineNo = "31420",
                         SerialNo = "CNB1P3Q1DB",
                         Location = "Payroll Copier (Sarah)",
                         Department = "Admin",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=42, IP = "172.16.1.167",
                         Name = "SWAFTM",
                         Model = "E60165",
                         MachineNo = "31530",
                         SerialNo = "CNMRPCL754",
                         Location = "SWT Aftermarket (Trish)",
                         Department = "Sales SWT",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=43, IP = "172.16.1.168",
                         Name = "STADMIN",
                         Model = "E60165",
                         MachineNo = "31529",
                         SerialNo = "CNMRPCL75C",
                         Location = "SWT Admin Clerk 2(Belinda)",
                         Department = "CL New Cars(Admin)",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=44, IP = "172.16.1.179",
                         Name = "SWPICK",
                         Model = "P3045DN",
                         MachineNo = "####",
                         SerialNo = "VM59206607",
                         Location = "SW Picking Slip (Daniel)",
                         Department = "Parts SWT",
                         Manufacturer = "Kyocera",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=45, IP = "172.16.1.210",
                         Name = "####",
                         Model = "ZT410",
                         MachineNo = "####",
                         SerialNo = "18J155301053",
                         Location = "SWT Parts Warehouse (Middle)",
                         Department = "Parts SWT",
                         Manufacturer = "Zebra",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=46, IP = "172.16.1.211",
                         Name = "####",
                         Model = "ZT410",
                         MachineNo = "####",
                         SerialNo = "18J170405949",
                         Location = "SWT Parts Warehouse (Daniel)",
                         Department = "Parts SWT",
                         Manufacturer = "Zebra",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=47, IP = "172.16.1.150",
                         Name = "STSADM1",
                         Model = "E60165",
                         MachineNo = "31506",
                         SerialNo = "CNMRPCL75N",
                         Location = "SWT Service (Gayle)",
                         Department = "Service SWT",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=48, IP = "172.16.1.151",
                         Name = "STFIMAN",
                         Model = "E52645",
                         MachineNo = "31445",
                         SerialNo = "####",
                         Location = "SWT Business Manager (Rod)",
                         Department = "New Car SWT",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },

                     new PrinterModel {
                       Id=49, IP = "172.16.1.152",
                         Name = "STGOPA",
                         Model = "E57540",
                         MachineNo = "31543",
                         SerialNo = "CNBRPCJ4XP",
                         Location = "Director PA (Mandie)",
                         Department = "Admin SWT",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodToyota
                     },
















                     new PrinterModel {
                       Id=50, IP = "172.16.2.149",
                         Name = "SMBM1",
                         Model = "E78325",
                         MachineNo = "31424",
                         SerialNo = "CNB1P3Q1DJ",
                         Location = "SM Business Manager (Chris)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },

                     new PrinterModel {
                       Id=51, IP = "172.16.2.150",
                         Name = "SMFLEET",
                         Model = "E77825",
                         MachineNo = "31432",
                         SerialNo = "CNB8K3A0F3",
                         Location = "SM Fleet (Loona)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=52, IP = "172.16.2.151",
                         Name = "SMRECEPTION",
                         Model = "E77830",
                         MachineNo = "22935",
                         SerialNo = "CNB8K831L1",
                         Location = "SM New Cars (Reception)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=53, IP = "172.16.2.152",
                         Name = "SMBM2",
                         Model = "E77822",
                         MachineNo = "22933",
                         SerialNo = "CNB8K831KY",
                         Location = "SM Business Manager (Amanda)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=54, IP = "172.16.2.153",
                         Name = "SMMARKET",
                         Model = "E55040",
                         MachineNo = "31462",
                         SerialNo = "####",
                         Location = "SM Marketing Manager (Amanda",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=55, IP = "172.16.2.154",
                         Name = "SMSALEMAN",
                         Model = "E55040",
                         MachineNo = "31456",
                         SerialNo = "JPBRP8F338",
                         Location = "SM Sales Manager (Jason)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=56, IP = "172.16.2.155",
                         Name = "SMSCON",
                         Model = "E60155",
                         MachineNo = "31444",
                         SerialNo = "####",
                         Location = "SM Stock Control (Jade)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=57, IP = "172.16.2.156",
                         Name = "SWMAFT",
                         Model = "E60165",
                         MachineNo = "31481",
                         SerialNo = "####",
                         Location = "SM Aftermarket (Lucinda)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },

                                          new PrinterModel {
                                            Id=58, IP = "172.16.2.158",
                                              Name = "SMUTECH",
                                              Model = "E60155",
                                              MachineNo = "31452",
                                              SerialNo = "CNMKM6RB28",
                                              Location = "SM Used Cars Tech (Wesley)",
                                              Department = "SM Used Cars",
                                              Manufacturer = "HP",
                                              Site = GlobalConfig.SpringwoodMazdaSales
                                          },

                     new PrinterModel {
                       Id=59, IP = "172.16.2.159",
                         Name = "SMUCOPIER",
                         Model = "ES8473",
                         MachineNo = "31639",
                         SerialNo = "CNB8K2S0M2",
                         Location = "SM Used Cars",
                         Department = "SM Used Cars",
                         Manufacturer = "Oki",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },





                     new PrinterModel {
                       Id=60, IP = "172.16.2.160",
                         Name = "SMDP",
                         Model = "E57540",
                         MachineNo = "31542",
                         SerialNo = "CNBRPCJ4TX",
                         Location = "SM Dealer Principle (Cleve)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=61, IP = "172.16.2.161",
                         Name = "SMCRMCOPIER",
                         Model = "E52645",
                         MachineNo = "31446",
                         SerialNo = "CNCRNDXB4Z",
                         Location = "SM CRM Copier (Amanda)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=62, IP = "172.16.2.165",
                         Name = "SMBM3",
                         Model = "E77822",
                         MachineNo = "31634",
                         SerialNo = "CND1N6702V",
                         Location = "SM Business Manager (Matthew)",
                         Department = "SM New Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },


                     new PrinterModel {
                       Id=63, IP = "172.16.2.168",
                         Name = "SMUSED",
                         Model = "E60165",
                         MachineNo = "31527",
                         SerialNo = "CNMRPCL5HR",
                         Location = "SM Used Cars",
                         Department = "SM Used Cars",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaSales
                     },










                     new PrinterModel {
                       Id=64, IP = "172.16.6.161",
                         Name = "SMPARTS",
                         Model = "E60165",
                         MachineNo = "31515",
                         SerialNo = "CNMRPCL5ZY",
                         Location = "SM Parts (Rob)",
                         Department = "Parts SM",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaServices
                     },

                     new PrinterModel {
                       Id=65, IP = "172.16.6.162",
                         Name = "SMSRO",
                         Model = "E60165",
                         MachineNo = "31507",
                         SerialNo = "CNMRPCL743",
                         Location = "SM Service R/O (David)",
                         Department = "Service SM",
                         Manufacturer = "HP",
                         Site = GlobalConfig.SpringwoodMazdaServices
                     },

                       new PrinterModel {
                         Id=66, IP = "172.16.6.163",
                           Name = "SMSMAN",
                           Model = "E60165",
                           MachineNo = "31455",
                           SerialNo = "####",
                           Location = "SM Service Manager (Ray)",
                           Department = "Service SM",
                           Manufacturer = "HP",
                           Site = GlobalConfig.SpringwoodMazdaServices
                       },


                        new PrinterModel {
                          Id=67, IP = "172.16.6.164",
                            Name = "SMCOPIER",
                            Model = "E78325",
                            MachineNo = "31427",
                            SerialNo = "CNB1P3Q1FV",
                            Location = "SM Service Copier",
                            Department = "Service SM",
                            Manufacturer = "HP",
                            Site = GlobalConfig.SpringwoodMazdaServices
                        },

                       new PrinterModel {
                         Id=68, IP = "172.16.6.166",
                           Name = "SMSINV",
                           Model = "E60165",
                           MachineNo = "31448",
                           SerialNo = "CNMKM7P2KT",
                           Location = "SM Invoice (Nick)",
                           Department = "Service SM",
                           Manufacturer = "HP",
                           Site = GlobalConfig.SpringwoodMazdaServices
                       },


                    new PrinterModel {
                      Id=69, IP = "172.16.6.167",
                        Name = "SMSWAR",
                        Model = "E60165",
                        MachineNo = "31510",
                        SerialNo = "CNMRPCL6ZH",
                        Location = "SM Warranty Clerk (Caralyn)",
                        Department = "Service SM",
                        Manufacturer = "HP",
                        Site = GlobalConfig.SpringwoodMazdaServices
                    },












                     new PrinterModel {
                       Id=70, IP = "172.16.3.144",
                         Name = "CLMGSROOM",
                         Model = "E60165",
                         MachineNo = "31525",
                         SerialNo = "CNMRPCL78L",
                         Location = "CLMG Showroom (Ethan)",
                         Department = "New Cars CLMG",
                         Manufacturer = "HP",
                         Site = GlobalConfig.ClevelandMG
                     },

                     new PrinterModel {
                       Id=71, IP = "172.16.3.148",
                         Name = "CLMGINV",
                         Model = "MP2001",
                         MachineNo = "31423",
                         SerialNo = "CNB1P3Q1DS",
                         Location = "CLMG Service (Sarah)",
                         Department = "Service CLMG",
                         Manufacturer = "HP",
                         Site = GlobalConfig.ClevelandMG
                     },

                     new PrinterModel {
                       Id=72, IP = "172.16.3.152",
                         Name = "CMGCOPIER",
                         Model = "MPC2004",
                         MachineNo = "31421",
                         SerialNo = "CNB1P3Q1F2",
                         Location = "CLMG New Cars (Robert)",
                         Department = "New Cars CLMG",
                         Manufacturer = "HP",
                         Site = GlobalConfig.ClevelandMG
                     },









                                            new PrinterModel {
                                              Id=73, IP = "172.16.3.145",
                                                Name = "CTRECEPTION",
                                                Model = "E60165",
                                                MachineNo = "31520",
                                                SerialNo = "CNMRPCL77C",
                                                Location = "CLT Reception (Rosina)",
                                                Department = "New Cars CLT",
                                                Manufacturer = "HP",
                                                Site = GlobalConfig.ClevelandToyota
                                            },
                                               new PrinterModel {
                                                 Id=74, IP = "172.16.3.149",
                                                   Name = "CTWAR",
                                                   Model = "E60165",
                                                   MachineNo = "31524",
                                                   SerialNo = "CNMRPCL5HD",
                                                   Location = "CLT Warranty (Kasey)",
                                                   Department = "Service CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=75, IP = "172.16.3.151",
                                                   Name = "CTBM1",
                                                   Model = "E87650",
                                                   MachineNo = "31641",
                                                   SerialNo = "CNB8K2S0LH",
                                                   Location = "CLT Finance Office (Craig)",
                                                   Department = "Finance  CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=76, IP = "172.16.3.153",
                                                   Name = "CTNCOPIER",
                                                   Model = "E78325",
                                                   MachineNo = "31426",
                                                   SerialNo = "CNB1P3Q1F5",
                                                   Location = "CLT New Cars (Room near New Car)",
                                                   Department = "New Cars CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=77, IP = "172.16.3.154",
                                                   Name = "CTSCOPIER",
                                                   Model = "E78325",
                                                   MachineNo = "31428",
                                                   SerialNo = "CNB1P3Q1F9",
                                                   Location = "CLT Service (Service Advisors)",
                                                   Department = "Service CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=78, IP = "172.16.3.155",
                                                   Name = "CTFLEET",
                                                   Model = "E55040",
                                                   MachineNo = "31459",
                                                   SerialNo = "JPBRP8F34H",
                                                   Location = "CLT New Cars Manager (Paul)",
                                                   Department = "New Cars CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=79, IP = "172.16.3.157",
                                                   Name = "CTBM2",
                                                   Model = "E78325",
                                                   MachineNo = "31417",
                                                   SerialNo = "CNB1P3Q1FC",
                                                   Location = "CLT Used Cars Finance (Spare)",
                                                   Department = "Used Cars Finance CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=80, IP = "172.16.3.158",
                                                   Name = "CTSRO",
                                                   Model = "E60165",
                                                   MachineNo = "31522",
                                                   SerialNo = "CNMRPCL5J2",
                                                   Location = "CLT Service R/O (Workshop)",
                                                   Department = "Service CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=81, IP = "172.16.3.161",
                                                   Name = "CTSINV",
                                                   Model = "E60165",
                                                   MachineNo = "31526",
                                                   SerialNo = "CNMRPCL5H2",
                                                   Location = "CLT Service Invoice (Service Advisors)",
                                                   Department = "Service CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=82, IP = "172.16.3.162",
                                                   Name = "CTNEW\t",
                                                   Model = "E60165",
                                                   MachineNo = "31519",
                                                   SerialNo = "CNMRPCL5GS",
                                                   Location = "CLT New Cars (Allan)",
                                                   Department = "New Cars CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=83, IP = "172.16.3.164",
                                                   Name = "CTPINV",
                                                   Model = "E60165",
                                                   MachineNo = "31521",
                                                   SerialNo = "CNMRPCL5FF",
                                                   Location = "CLT Parts (Front Counter)",
                                                   Department = "Parts CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
                                               new PrinterModel {
                                                 Id=84, IP = "172.16.3.167",
                                                   Name = "CTPWHSE",
                                                   Model = "E60165",
                                                   MachineNo = "31514",
                                                   SerialNo = "CNMRPCL562",
                                                   Location = "CLT Parts Warehouse (Warehouse)",
                                                   Department = "Parts CLT",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.ClevelandToyota
                                               },
















                                               new PrinterModel {
                                                 Id=85, IP = "172.16.5.152",
                                                   Name = "RMGM",
                                                   Model = "E57540",
                                                   MachineNo = "31541",
                                                   SerialNo = "CNBRPCJ5D7",
                                                   Location = "Peter Niebling Office",
                                                   Department = "Admin RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=86, IP = "172.16.5.200",
                                                   Name = "RMNEW",
                                                   Model = "E60165",
                                                   MachineNo = "31511",
                                                   SerialNo = "CNMRPCL5WC",
                                                   Location = "RM New Cars (behind Reception)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=87, IP = "172.16.5.201",
                                                   Name = "RMRECEPTION",
                                                   Model = "E87650",
                                                   MachineNo = "31642",
                                                   SerialNo = "CNB8K6M0G1",
                                                   Location = "RM New Cars (beside Peter's room)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=88, IP = "172.16.5.202",
                                                   Name = "RMBM1",
                                                   Model = "E77822",
                                                   MachineNo = "31632",
                                                   SerialNo = "CND1N6B01L",
                                                   Location = "RM New Cars (Clare)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=89, IP = "172.16.5.203",
                                                   Name = "RMBM2",
                                                   Model = "E78330",
                                                   MachineNo = "31630",
                                                   SerialNo = "CNB1P960G3",
                                                   Location = "RM New Cars (Alex)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=90, IP = "172.16.5.204",
                                                   Name = "RMAFT",
                                                   Model = "E60155",
                                                   MachineNo = "31454",
                                                   SerialNo = "CNMKM6R9X7",
                                                   Location = "RM Aftermarket (Cathy)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=91, IP = "172.16.5.205",
                                                   Name = "RMSRO",
                                                   Model = "P3045dn",
                                                   MachineNo = "VM3163559306928",
                                                   SerialNo = "####",
                                                   Location = "RM Service RO (Matt Poole)",
                                                   Department = "Service RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=92, IP = "172.16.5.206",
                                                   Name = "RMSINV",
                                                   Model = "E78330",
                                                   MachineNo = "31635",
                                                   SerialNo = "CNB1P960G9",
                                                   Location = "RM Service (John)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=93, IP = "172.16.5.207",
                                                   Name = "RMPARTS",
                                                   Model = "E60165",
                                                   MachineNo = "31508",
                                                   SerialNo = "CNMRPCL5ZJ",
                                                   Location = "RM Parts (Thomas)",
                                                   Department = "Parts RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=94, IP = "172.16.5.208",
                                                   Name = "RMWAR",
                                                   Model = "E60155",
                                                   MachineNo = "31453",
                                                   SerialNo = "CNMKM6K4PY",
                                                   Location = "RM Warranty Clerk (Emma)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=95, IP = "172.16.5.209",
                                                   Name = "RMSMAN",
                                                   Model = "E55040",
                                                   MachineNo = "31549",
                                                   SerialNo = "JPBRP6807D",
                                                   Location = "RM Service Manager (Richard)",
                                                   Department = "Service RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },

                                               new PrinterModel {
                                                 Id=96, IP = "172.16.5.210",
                                                   Name = "RMNSMAN",
                                                   Model = "E60165",
                                                   MachineNo = "31509",
                                                   SerialNo = "CNMRPCL5Z5",
                                                   Location = "RM New Car Manager (Nathan)",
                                                   Department = "New Car RM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.RedlandsMazda
                                               },










                                               new PrinterModel {
                                                 Id=97, IP = "172.16.4.142",
                                                   Name = "STPDO",
                                                   Model = "E60165",
                                                   MachineNo = "31522",
                                                   SerialNo = "CNMRPCL54C",
                                                   Location = "SWM Pre-Delivery Office (Helen)",
                                                   Department = "Service SWM",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=98, IP = "172.16.4.143",
                                                   Name = "####",
                                                   Model = "ZM400",
                                                   MachineNo = "ZBR3815953",
                                                   SerialNo = "####",
                                                   Location = "PD Parts (Karen)",
                                                   Department = "Parts SWT",
                                                   Manufacturer = "Zebra",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=99, IP = "172.16.4.144",
                                                   Name = "STREGO",
                                                   Model = "E60165",
                                                   MachineNo = "31517",
                                                   SerialNo = "CNMRPCL54P",
                                                   Location = "PD Office - Toyota (Louise)",
                                                   Department = "Admin",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=100, IP = "172.16.4.150",
                                                   Name = "SMREGO",
                                                   Model = "P3045DN",
                                                   MachineNo = "VM59306911",
                                                   SerialNo = "####",
                                                   Location = "PD Office - Mazda (Simone)",
                                                   Department = "Admin",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=101, IP = "172.16.4.155",
                                                   Name = "PDCOPIER",
                                                   Model = "E77830",
                                                   MachineNo = "CNB8K831JZ",
                                                   SerialNo = "####",
                                                   Location = "PD Office",
                                                   Department = "Admin",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=102, IP = "172.16.4.160",
                                                   Name = "PDGATE",
                                                   Model = "M1145",
                                                   MachineNo = "45145PHH2P56D",
                                                   SerialNo = "####",
                                                   Location = "PD Guard House (Jackie)",
                                                   Department = "Admin",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               },

                                               new PrinterModel {
                                                 Id=103, IP = "172.16.4.161",
                                                   Name = "PDPTS",
                                                   Model = "M1145",
                                                   MachineNo = "45145PHH2P56B",
                                                   SerialNo = "####",
                                                   Location = "PD Office (Karen)",
                                                   Department = "Admin",
                                                   Manufacturer = "HP",
                                                   Site = GlobalConfig.KinstonPD
                                               }

      );
        }
    }
}
