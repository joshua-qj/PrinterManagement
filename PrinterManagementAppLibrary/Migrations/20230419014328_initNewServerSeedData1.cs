using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrinterManagementAppLibrary.Migrations
{
    public partial class initNewServerSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNo",
                table: "Printers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Printers",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "Printers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "MachineNo",
                table: "Printers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Printers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Printers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "Id", "Department", "IP", "Location", "MachineNo", "Manufacturer", "Model", "Name", "SerialNo", "Site" },
                values: new object[,]
                {
                    { 3, "Admin", "172.16.1.120", "SWT Accounts Pay (Sarah)", "31447", "HP", "E60165", "ACCPAY", "CNMKM6R9ZV", "GoldCoast" },
                    { 4, "Admin", "172.16.1.121", "SWT Accounts Rec (Lorraine)", "31469", "HP", "E60165", "ACCREC", "CNMRPCL540", "GoldCoast" },
                    { 5, "New Cars SWT", "172.16.1.122", "SWT Admin Clerk 1 (Jiki)", "31466", "HP", "E60165", "STVEHPRO", "CNMRPCL5JT", "GoldCoast" },
                    { 6, "New Cars SWT", "172.16.1.123", "SWT Vehicle Processing (Nick)", "31463", "HP", "E60165", "STFLEET2", "CNMRPCL5K4", "GoldCoast" },
                    { 7, "New Cars SWT", "172.16.1.124", "SWT Fleet Manager (Ben)", "31464", "HP", "E60165", "STFMAN", "CNMRPCL5KN", "GoldCoast" },
                    { 8, "New Cars SWT", "172.16.1.125", "SWT Stock Control 2 (Rebecca)", "31468", "HP", "E60165", "STSTOCK2", "CNMRPCL5L1", "GoldCoast" },
                    { 9, "Admin", "172.16.1.127", "HR Manager (Kathy)", "31465", "HP", "E60165", "HRMAN", "CNMRPCL5M1", "GoldCoast" },
                    { 10, "Admin", "172.16.1.128", "SWT Admin Manager (Fiona)", "31467", "HP", "E60165", "STOM", "CNMRPCL5MM", "GoldCoast" },
                    { 11, "Admin", "172.16.1.129", "SWT Group Financial Controller (Greig)", "31457", "HP", "E55040", "STACC2", "JPBRP8F323", "GoldCoast" },
                    { 12, "Used Cars SWT", "172.16.1.130", "SWT Used Cars Manager (Steve)", "31460", "HP", "E55040", "STUSEDCOLOUR", "JPBRP8F329", "GoldCoast" },
                    { 13, "Service SWT", "172.16.1.134", "SWT Admin (Scanner)", "???", "HP", "8500FN2", "STSCANNER", "CN7B713024", "GoldCoast" },
                    { 14, "Admin Mazda", "172.16.1.137", "SWM Office Clerk (Cassie)", "31470", "HP", "E60165", "SMOFFMAN", "CNMRPCL5N5", "GoldCoast" },
                    { 15, "Service SWT", "172.16.1.138", "SWT Fleet BM (Kristy)", "31486", "HP", "E60165", "STFLEETBM", "CNMRPCL4SN", "GoldCoast" },
                    { 16, "Fleet SWT", "172.16.1.140", "SWT Fleet Manager (Daniel)", "31483", "HP", "E60165", "STFLEET3", "CNMRPCL4T6", "GoldCoast" },
                    { 17, "Admin", "172.16.1.141", "SWT Payroll (Sarah)", "31484", "HP", "E60165", "SWPAY", "CNMRPCL5Y5", "GoldCoast" },
                    { 18, "Service SWT", "172.16.1.142", "SWT Service (Sumeshan)", "31485", "HP", "E60165", "STSAM", "CNMRPCL6CM", "GoldCoast" },
                    { 19, "Finance SWT", "172.16.1.143", "ST Reception 2", "31636", "Oki", "E77822", "STRECEPTION2", "CND1N64020", "GoldCoast" },
                    { 20, "Admin  SWT", "172.16.1.144", "SWT Admin (1st Floor)", "22938", "HP", "E77830", "STACOPIER", "CNB8K7R26G", "GoldCoast" },
                    { 21, "Used Cars SWT", "172.16.1.145", "SWT Used Cars Service (Mark)", "31482", "HP", "E60155", "STUTECH", "CNMRPCL6DJ", "GoldCoast" },
                    { 22, "Used Cars SWT", "172.16.1.146", "SWT Used Cars (Billy)", "31496", "HP", "E60155", "STWSALE", "CNMRPCL6B7", "GoldCoast" },
                    { 23, "Admin  SWT", "172.16.1.147", "IT Dept (Craig)", "31487", "HP", "E60165", "IT", "CNMRPCL6C8", "GoldCoast" },
                    { 24, "Admin  SWT", "172.16.1.148", "IT Dept (Craig)", "31422", "HP", "E78325", "ITCOPIER", "CNB1P3Q1CQ", "GoldCoast" },
                    { 25, "New Cars SWT", "172.16.1.149", "SWT New Cars", "22936", "HP", "E77830", "STRECEPTION", "CNB8K7R26M", "GoldCoast" },
                    { 26, "Admin", "172.16.1.150", "SWT Group CFO (Richard)", "31461", "HP", "E55040", "FINCON", "JPBRP8F33W", "GoldCoast" },
                    { 27, "Finance SWT", "172.16.1.151", "SWT Finance Business Manager 2 (Jillian)", "22939", "HP", "E77830", "STBM2COPIER", "CNB8K7R26W", "GoldCoast" },
                    { 28, "Parts SWT", "172.16.1.152", "SWT Parts Warehouse", "31640", "Oki", "E87650", "STPCOPIER", "CNB8K2S0LB", "GoldCoast" },
                    { 29, "Service SWT", "172.16.1.153", "SWT Service (David)", "31637", "HP", "E77822", "STSCOPIER", "CND1N64023", "GoldCoast" },
                    { 30, "Used Cars SWT", "172.16.1.154", "SWT Used Cars (Steve)", "31638", "Oki", "E77822", "STUSEDCOPIER", "CND1N6702Q", "GoldCoast" },
                    { 31, "Finance SWT", "172.16.1.155", "SWT Finance Business Manager 1 (Sarah)", "31629", "Oki", "E78330", "STBM1COPIER", "CNB1P960G1", "GoldCoast" },
                    { 32, "Admin  SWT", "172.16.1.156", "SWT Fixed Operation Office (David)", "31631", "Oki", "E78330", "STFXDOPCOPIER", "CNB1P960G2", "GoldCoast" },
                    { 33, "Fleet  SWT", "172.16.1.157", "SWT Fleet 1 (Chris)", "31497", "HP", "E60165", "STFLEET", "CNMRPCL68G", "GoldCoast" },
                    { 34, "Admin", "172.16.1.159", "SWT Accountant (Vineel)", "31458", "HP", "E55040", "STACC3", "JPBRP8F31N", "GoldCoast" },
                    { 35, "Service SWT", "172.16.1.160", "SWT Service R/Orders (Craig)", "31500", "HP", "E60165", "STSRO", "CNMRPCL699", "GoldCoast" },
                    { 36, "Parts SWT", "172.16.1.161", "SWT Parts Warehouse (Middle)", "31501", "HP", "E60165", "STPARTS", "CNMRPCL68P", "GoldCoast" },
                    { 37, "Service SWT", "172.16.1.162", "SWT Service Invoice (Kiara)", "31499", "HP", "E60165", "STSINV", "CNMRPCL624", "GoldCoast" },
                    { 38, "New Cars SWT", "172.16.1.163", "SWT New Cars", "31498", "HP", "E60165", "STNEW", "CNMRPCL6D4", "GoldCoast" },
                    { 39, "Parts SWT", "172.16.1.164", "SWT Parts Ph Room (Brandon)", "31503", "HP", "E60165", "STPINV", "CNMRPCL67F", "GoldCoast" },
                    { 40, "Used Cars SWT", "172.16.1.165", "SWT Used Cars (Jason)", "31502", "HP", "E60165", "STUSED", "CNMRPCL6BJ", "GoldCoast" },
                    { 41, "Admin", "172.16.1.166", "Payroll Copier (Sarah)", "31420", "HP", "E78325", "PAYCOPYA3", "CNB1P3Q1DB", "GoldCoast" },
                    { 42, "Sales SWT", "172.16.1.167", "SWT Aftermarket (Trish)", "31530", "HP", "E60165", "SWAFTM", "CNMRPCL754", "GoldCoast" },
                    { 43, "CL New Cars(Admin)", "172.16.1.168", "SWT Admin Clerk 2(Belinda)", "31529", "HP", "E60165", "STADMIN", "CNMRPCL75C", "GoldCoast" },
                    { 44, "Parts SWT", "172.16.1.179", "SW Picking Slip (Daniel)", "####", "Kyocera", "P3045DN", "SWPICK", "VM59206607", "GoldCoast" }
                });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "Id", "Department", "IP", "Location", "MachineNo", "Manufacturer", "Model", "Name", "SerialNo", "Site" },
                values: new object[,]
                {
                    { 45, "Parts SWT", "172.16.1.210", "SWT Parts Warehouse (Middle)", "####", "Zebra", "ZT410", "####", "18J155301053", "GoldCoast" },
                    { 46, "Parts SWT", "172.16.1.211", "SWT Parts Warehouse (Daniel)", "####", "Zebra", "ZT410", "####", "18J170405949", "GoldCoast" },
                    { 47, "Service SWT", "172.16.1.150", "SWT Service (Gayle)", "31506", "HP", "E60165", "STSADM1", "CNMRPCL75N", "GoldCoast" },
                    { 48, "New Car SWT", "172.16.1.151", "SWT Business Manager (Rod)", "31445", "HP", "E52645", "STFIMAN", "####", "GoldCoast" },
                    { 49, "Admin SWT", "172.16.1.152", "Director PA (Mandie)", "31543", "HP", "E57540", "STGOPA", "CNBRPCJ4XP", "GoldCoast" },
                    { 50, "SM New Cars", "172.16.2.149", "SM Business Manager (Chris)", "31424", "HP", "E78325", "SMBM1", "CNB1P3Q1DJ", "SpringwoodMazdaSales" },
                    { 51, "SM New Cars", "172.16.2.150", "SM Fleet (Loona)", "31432", "HP", "E77825", "SMFLEET", "CNB8K3A0F3", "SpringwoodMazdaSales" },
                    { 52, "SM New Cars", "172.16.2.151", "SM New Cars (Reception)", "22935", "HP", "E77830", "SMRECEPTION", "CNB8K831L1", "SpringwoodMazdaSales" },
                    { 53, "SM New Cars", "172.16.2.152", "SM Business Manager (Amanda)", "22933", "HP", "E77822", "SMBM2", "CNB8K831KY", "SpringwoodMazdaSales" },
                    { 54, "SM New Cars", "172.16.2.153", "SM Marketing Manager (Amanda", "31462", "HP", "E55040", "SMMARKET", "####", "SpringwoodMazdaSales" },
                    { 55, "SM New Cars", "172.16.2.154", "SM Sales Manager (Jason)", "31456", "HP", "E55040", "SMSALEMAN", "JPBRP8F338", "SpringwoodMazdaSales" },
                    { 56, "SM New Cars", "172.16.2.155", "SM Stock Control (Jade)", "31444", "HP", "E60155", "SMSCON", "####", "SpringwoodMazdaSales" },
                    { 57, "SM New Cars", "172.16.2.156", "SM Aftermarket (Lucinda)", "31481", "HP", "E60165", "SWMAFT", "####", "SpringwoodMazdaSales" },
                    { 58, "SM Used Cars", "172.16.2.158", "SM Used Cars Tech (Wesley)", "31452", "HP", "E60155", "SMUTECH", "CNMKM6RB28", "SpringwoodMazdaSales" },
                    { 59, "SM Used Cars", "172.16.2.159", "SM Used Cars", "31639", "Oki", "ES8473", "SMUCOPIER", "CNB8K2S0M2", "SpringwoodMazdaSales" },
                    { 60, "SM New Cars", "172.16.2.160", "SM Dealer Principle (Cleve)", "31542", "HP", "E57540", "SMDP", "CNBRPCJ4TX", "SpringwoodMazdaSales" },
                    { 61, "SM New Cars", "172.16.2.161", "SM CRM Copier (Amanda)", "31446", "HP", "E52645", "SMCRMCOPIER", "CNCRNDXB4Z", "SpringwoodMazdaSales" },
                    { 62, "SM New Cars", "172.16.2.165", "SM Business Manager (Matthew)", "31634", "HP", "E77822", "SMBM3", "CND1N6702V", "SpringwoodMazdaSales" },
                    { 63, "SM Used Cars", "172.16.2.168", "SM Used Cars", "31527", "HP", "E60165", "SMUSED", "CNMRPCL5HR", "SpringwoodMazdaSales" },
                    { 64, "Parts SM", "172.16.6.161", "SM Parts (Rob)", "31515", "HP", "E60165", "SMPARTS", "CNMRPCL5ZY", "SpringwoodMazdaServices" },
                    { 65, "Service SM", "172.16.6.162", "SM Service R/O (David)", "31507", "HP", "E60165", "SMSRO", "CNMRPCL743", "SpringwoodMazdaServices" },
                    { 66, "Service SM", "172.16.6.163", "SM Service Manager (Ray)", "31455", "HP", "E60165", "SMSMAN", "####", "SpringwoodMazdaServices" },
                    { 67, "Service SM", "172.16.6.164", "SM Service Copier", "31427", "HP", "E78325", "SMCOPIER", "CNB1P3Q1FV", "SpringwoodMazdaServices" },
                    { 68, "Service SM", "172.16.6.166", "SM Invoice (Nick)", "31448", "HP", "E60165", "SMSINV", "CNMKM7P2KT", "SpringwoodMazdaServices" },
                    { 69, "Service SM", "172.16.6.167", "SM Warranty Clerk (Caralyn)", "31510", "HP", "E60165", "SMSWAR", "CNMRPCL6ZH", "SpringwoodMazdaServices" },
                    { 70, "New Cars CLMG", "172.16.3.144", "CLMG Showroom (Ethan)", "31525", "HP", "E60165", "CLMGSROOM", "CNMRPCL78L", "ClevelandMG" },
                    { 71, "Service CLMG", "172.16.3.148", "CLMG Service (Sarah)", "31423", "HP", "MP2001", "CLMGINV", "CNB1P3Q1DS", "ClevelandMG" },
                    { 72, "New Cars CLMG", "172.16.3.152", "CLMG New Cars (Robert)", "31421", "HP", "MPC2004", "CMGCOPIER", "CNB1P3Q1F2", "ClevelandMG" },
                    { 73, "New Cars CLT", "172.16.3.145", "CLT Reception (Rosina)", "31520", "HP", "E60165", "CTRECEPTION", "CNMRPCL77C", "Cleveland" },
                    { 74, "Service CLT", "172.16.3.149", "CLT Warranty (Kasey)", "31524", "HP", "E60165", "CTWAR", "CNMRPCL5HD", "Cleveland" },
                    { 75, "Finance  CLT", "172.16.3.151", "CLT Finance Office (Craig)", "31641", "HP", "E87650", "CTBM1", "CNB8K2S0LH", "Cleveland" },
                    { 76, "New Cars CLT", "172.16.3.153", "CLT New Cars (Room near New Car)", "31426", "HP", "E78325", "CTNCOPIER", "CNB1P3Q1F5", "Cleveland" },
                    { 77, "Service CLT", "172.16.3.154", "CLT Service (Service Advisors)", "31428", "HP", "E78325", "CTSCOPIER", "CNB1P3Q1F9", "Cleveland" },
                    { 78, "New Cars CLT", "172.16.3.155", "CLT New Cars Manager (Paul)", "31459", "HP", "E55040", "CTFLEET", "JPBRP8F34H", "Cleveland" },
                    { 79, "Used Cars Finance CLT", "172.16.3.157", "CLT Used Cars Finance (Spare)", "31417", "HP", "E78325", "CTBM2", "CNB1P3Q1FC", "Cleveland" },
                    { 80, "Service CLT", "172.16.3.158", "CLT Service R/O (Workshop)", "31522", "HP", "E60165", "CTSRO", "CNMRPCL5J2", "Cleveland" },
                    { 81, "Service CLT", "172.16.3.161", "CLT Service Invoice (Service Advisors)", "31526", "HP", "E60165", "CTSINV", "CNMRPCL5H2", "Cleveland" },
                    { 82, "New Cars CLT", "172.16.3.162", "CLT New Cars (Allan)", "31519", "HP", "E60165", "CTNEW	", "CNMRPCL5GS", "Cleveland" },
                    { 83, "Parts CLT", "172.16.3.164", "CLT Parts (Front Counter)", "31521", "HP", "E60165", "CTPINV", "CNMRPCL5FF", "Cleveland" },
                    { 84, "Parts CLT", "172.16.3.167", "CLT Parts Warehouse (Warehouse)", "31514", "HP", "E60165", "CTPWHSE", "CNMRPCL562", "Cleveland" },
                    { 85, "Admin RM", "172.16.5.152", "Peter Niebling Office", "31541", "HP", "E57540", "RMGM", "CNBRPCJ5D7", "Brisbane" },
                    { 86, "New Car RM", "172.16.5.200", "RM New Cars (behind Reception)", "31511", "HP", "E60165", "RMNEW", "CNMRPCL5WC", "Brisbane" }
                });

            migrationBuilder.InsertData(
                table: "Printers",
                columns: new[] { "Id", "Department", "IP", "Location", "MachineNo", "Manufacturer", "Model", "Name", "SerialNo", "Site" },
                values: new object[,]
                {
                    { 87, "New Car RM", "172.16.5.201", "RM New Cars (beside Peter's room)", "31642", "HP", "E87650", "RMRECEPTION", "CNB8K6M0G1", "Brisbane" },
                    { 88, "New Car RM", "172.16.5.202", "RM New Cars (Clare)", "31632", "HP", "E77822", "RMBM1", "CND1N6B01L", "Brisbane" },
                    { 89, "New Car RM", "172.16.5.203", "RM New Cars (Alex)", "31630", "HP", "E78330", "RMBM2", "CNB1P960G3", "Brisbane" },
                    { 90, "New Car RM", "172.16.5.204", "RM Aftermarket (Cathy)", "31454", "HP", "E60155", "RMAFT", "CNMKM6R9X7", "Brisbane" },
                    { 91, "Service RM", "172.16.5.205", "RM Service RO (Matt Poole)", "VM3163559306928", "HP", "P3045dn", "RMSRO", "####", "Brisbane" },
                    { 92, "New Car RM", "172.16.5.206", "RM Service (John)", "31635", "HP", "E78330", "RMSINV", "CNB1P960G9", "Brisbane" },
                    { 93, "Parts RM", "172.16.5.207", "RM Parts (Thomas)", "31508", "HP", "E60165", "RMPARTS", "CNMRPCL5ZJ", "Brisbane" },
                    { 94, "New Car RM", "172.16.5.208", "RM Warranty Clerk (Emma)", "31453", "HP", "E60155", "RMWAR", "CNMKM6K4PY", "Brisbane" },
                    { 95, "Service RM", "172.16.5.209", "RM Service Manager (Richard)", "31549", "HP", "E55040", "RMSMAN", "JPBRP6807D", "Brisbane" },
                    { 96, "New Car RM", "172.16.5.210", "RM New Car Manager (Nathan)", "31509", "HP", "E60165", "RMNSMAN", "CNMRPCL5Z5", "Brisbane" },
                    { 97, "Service SWM", "172.16.4.142", "SWM Pre-Delivery Office (Helen)", "31522", "HP", "E60165", "STPDO", "CNMRPCL54C", "Sydney" },
                    { 98, "Parts SWT", "172.16.4.143", "PD Parts (Karen)", "ZBR3815953", "Zebra", "ZM400", "####", "####", "Sydney" },
                    { 99, "Admin", "172.16.4.144", "PD Office - Toyota (Louise)", "31517", "HP", "E60165", "STREGO", "CNMRPCL54P", "Sydney" },
                    { 100, "Admin", "172.16.4.150", "PD Office - Mazda (Simone)", "VM59306911", "HP", "P3045DN", "SMREGO", "####", "Sydney" },
                    { 101, "Admin", "172.16.4.155", "PD Office", "CNB8K831JZ", "HP", "E77830", "PDCOPIER", "####", "Sydney" },
                    { 102, "Admin", "172.16.4.160", "PD Guard House (Jackie)", "45145PHH2P56D", "HP", "M1145", "PDGATE", "####", "Sydney" },
                    { 103, "Admin", "172.16.4.161", "PD Office (Karen)", "45145PHH2P56B", "HP", "M1145", "PDPTS", "####", "Sydney" },
                    { 190, "Service SWT", "172.16.1.118", "SWT Warranty Clerk (Sharina)", "31451", "HP", "E60165", "STPWAR", "CNMKM7P2KF", "GoldCoast" },
                    { 192, "Admin  SWT", "172.16.1.119", "	Accounts Pay Mazda (Heidi)", "31450", "HP", "E60165", "STADMIN2", "CNMKM6RB3W", "GoldCoast" },
                    { 199, "Parts SWT", "172.16.1.117", "SWT Parts Manager (Andrew)", "31258", "HP", "E60165", "STPMAN", "CNMRPCL5J8", "GoldCoast" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Printers",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.AlterColumn<string>(
                name: "SerialNo",
                table: "Printers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Printers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "Printers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "MachineNo",
                table: "Printers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Printers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Printers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
