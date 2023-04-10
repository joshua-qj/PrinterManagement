using PrinterManagementAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary.DataAccess.SQL
{
    public interface IPrinterData
    {
        Task<PrinterModel> CreatePrinter(PrinterModel printer);
        Task DeletePrinter(int id);
        Task<List<PrinterModel>?> GetAllPrinters();
        Task<PrinterModel?> GetPrinter(int id);
        Task<PrinterModel?> UpdatePrinter(PrinterModel printer);
    }
}
