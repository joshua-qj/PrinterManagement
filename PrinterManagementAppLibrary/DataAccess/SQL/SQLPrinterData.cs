using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.DataAccess.SQL
{
    public class SQLPrinterData : IPrinterData
    {
        private readonly SQLDBContext _context;

        public SQLPrinterData(SQLDBContext context) {
            _context = context;
        }
        public async Task<PrinterModel> CreatePrinter(PrinterModel printer)
        {
            _context.Printers.Add(printer);
            await _context.SaveChangesAsync();
            return printer;
        }

        public async Task DeletePrinter(int id)
        {
           var printer=await _context.Printers.FindAsync(id);
            if (printer is not null) {
                _context.Remove(printer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<PrinterModel>?> GetAllPrinters()
        {
            var result= await _context.Printers.ToListAsync();
            return result;
        }
        public async Task<PrinterModel?> GetPrinter(int id) {
            PrinterModel? result = await _context.Printers.FirstOrDefaultAsync(p => p.Id == id);
            return result;
        }

        public async Task<PrinterModel?> UpdatePrinter(PrinterModel printer)
        {
            var dbPrinter = await GetPrinter(printer.Id);
            if (dbPrinter is not null) {
                dbPrinter.IP=printer.IP;
                dbPrinter.Manufacturer = printer.Manufacturer;
                dbPrinter.SerialNo= printer.SerialNo;
                dbPrinter.MachineNo= printer.MachineNo;
                dbPrinter.Department= printer.Department;
                dbPrinter.Location= printer.Location;
                dbPrinter.Name= printer.Name;
                dbPrinter.Model= printer.Model;               
                }
            else {
                return null ;
            }
            await _context.SaveChangesAsync();
            return printer;
        }
    }
}
