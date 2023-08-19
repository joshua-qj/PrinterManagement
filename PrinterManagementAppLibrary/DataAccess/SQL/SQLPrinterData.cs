using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.Models;
using System.Net.NetworkInformation;

namespace PrinterManagementAppLibrary.DataAccess.SQL {
    public class SQLPrinterData : IPrinterData {
        private readonly SQLDBContext _context;
        //public const string SpringwoodToyota = "SpringwoodToyota";
        public SQLPrinterData(SQLDBContext context) {
            _context = context;
        }
        public async Task<PrinterModel> CreatePrinter(PrinterModel printer) {
            _context.Printers.Add(printer);
            await _context.SaveChangesAsync();
            return printer;
        }

        public async Task DeletePrinter(int id) {
            var printer = await _context.Printers.FindAsync(id);
            if (printer is not null) {
                _context.Remove(printer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<PrinterModel>?> GetAllPrinters() {
            var result = await _context.Printers.ToListAsync();
            return result;
        }
        public async Task<List<PrinterModel>?> GetSpringwoodPrinters() {
            var result = await _context.Printers.Where(p => p.SiteId == 1).ToListAsync();
            return result;
        }

        public async Task<List<PrinterModel>?> GetClevelandPrinters() {
            var result = await _context.Printers.Where(p => p.SiteId == 2).ToListAsync();
            return result;
        }
        public async Task<List<PrinterModel>?> GetRedlandsPrinters() {
            var result = await _context.Printers.Where(p => p.SiteId == 3).ToListAsync();
            return result;
        }
        public async Task<List<PrinterModel>?> GetKinstonPrinters() {
            var result = await _context.Printers.Where(p => p.SiteId == 4).ToListAsync();
            return result;
        }


        public async Task<PrinterModel?> GetPrinter(int id) {
            PrinterModel? result = await _context.Printers.FirstOrDefaultAsync(p => p.Id == id);
            return result;
        }

        public async Task<PrinterModel?> UpdatePrinter(PrinterModel printer) {
            var dbPrinter = await GetPrinter(printer.Id);
            if (dbPrinter is not null) {
                dbPrinter.IP = printer.IP;
                dbPrinter.Manufacturer = printer.Manufacturer;
                dbPrinter.SerialNo = printer.SerialNo;
                dbPrinter.MachineNo = printer.MachineNo;
                dbPrinter.Department = printer.Department;
                dbPrinter.Location = printer.Location;
                dbPrinter.Name = printer.Name;
                dbPrinter.Model = printer.Model;
            }
            else {
                return null;
            }
            await _context.SaveChangesAsync();
            return printer;
        }

        public async Task PingPrinters(List<PrinterModel> printers) {

            Ping pinger = new();
            try {
                if (printers is not null) {
                    foreach (var printer in printers) {
                        PingReply reply = await pinger.SendPingAsync(printer.IP);
                        if (reply is { Status: IPStatus.Success }) {
                            printer.Status = "Online";
                        }
                        else {
                            printer.Status = "Offline";
                        }
                    }
                }
            }
            catch (Exception) {

                foreach (var printer in printers) {
                    printer.Status = "Offline";
                }
            }
        }

    }
}
