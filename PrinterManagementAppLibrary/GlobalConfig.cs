using PrinterManagementAppLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagementAppLibrary {
    public static class GlobalConfig {

        public const string SpringwoodToyota = "SpringwoodToyota";
        public const string SpringwoodMazdaSales = "SpringwoodMazdaSales";
        public const string SpringwoodMazdaServices = "SpringwoodMazdaServices";
        public const string ClevelandToyota = "ClevelandToyota";
        public const string ClevelandMG = "ClevelandMG";
        public const string RedlandsMazda = "RedlandsMazda";
        public const string KinstonPD = "KinstonPD";
        public static string CnnString() {
            // return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PrintersSQLDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        //public static IDataConnection Connection { get; private set; }
        //public static void InitializeConnections(DatabaseType db) {
        //    switch (db) {
        //        case DatabaseType.Sql:
        //            //Setup connection of SQL database
        //            SqlConnector sql = new SqlConnector();
        //            Connection = sql;
        //            break;
        //        case DatabaseType.TextFile:
        //            TextConnector text = new TextConnector();
        //            Connection = text;
        //            break;
        //        default:
        //            break;
        //    }
        //if (db==DatabaseType.Sql) {

        //}
        //if (db==DatabaseType.TextFile) {
        //    TextConnector text = new TextConnector();
        //    Connection=text;
        //}
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="database name"></param>
    /// <returns>database connection string</returns>


}
