using PrinterManagementAppLibrary.Models;

namespace PrinterManagementAppLibrary.DataAccess.SQL
{
    public interface IPrinterData
    {
        Task<PrinterModel> CreatePrinter(PrinterModel printer);
        Task DeletePrinter(int id);
        Task<List<PrinterModel>?> GetAllPrinters();
        Task<List<PrinterModel>?> GetClevelandPrinters();
        Task<List<PrinterModel>?> GetKinstonPrinters();
        Task<PrinterModel?> GetPrinter(int id);
        Task<List<PrinterModel>?> GetRedlandsPrinters(); 
        Task<List<PrinterModel>?> GetSpringwoodPrinters();
        Task PingPrinters(List<PrinterModel> printers);
        Task<PrinterModel?> UpdatePrinter(PrinterModel printer);
    }
}
