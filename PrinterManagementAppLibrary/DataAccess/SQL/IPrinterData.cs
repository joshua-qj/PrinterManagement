using PrinterManagementAppLibrary.Models;

namespace PrinterManagementAppLibrary.DataAccess.SQL
{
    public interface IPrinterData
    {
        Task<PrinterModel> CreatePrinter(PrinterModel printer);
        Task DeletePrinter(int id);
        Task<List<PrinterModel>?> GetAllPrinters();
        Task<List<PrinterModel>?> GetClevelandMGPrinters();
        Task<List<PrinterModel>?> GetClevelandToyotaPrinters();
        Task<List<PrinterModel>?> GetKinstonPDPrinters();
        Task<PrinterModel?> GetPrinter(int id);
        Task<List<PrinterModel>?> GetRedlandsMazdaPrinters();
        Task<List<PrinterModel>?> GetSpringwoodMazdaSalesPrinters();
        Task<List<PrinterModel>?> GetSpringwoodMazdaServicesPrinters();
        Task<List<PrinterModel>?> GetSpringwoodToyotaPrinters();
        Task<PrinterModel?> UpdatePrinter(PrinterModel printer);
    }
}
