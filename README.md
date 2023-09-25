# PrinterManagement
Printer Management

This project was created to manage printers, you can do CRUD operations for each printer. 
You can group printers by their site name, view printers IP address, printers networking status (pingable or not pingable), and goto printer's management webpage.

Prerequisites:
.net 7,
EF Core 7,
Blazor serverside runtime,
SQL Server.

Note:
SQL localdb was used in this branch.
Using @typeparam to create generic component, which is PrinterList.rzor.
Using Reflection to get properties and values.
Using Cascading parameters to pass a value from a component to all its descendants.

Code was deployed to Azure web app for demo purpose, Url is https://printermanagement2023.azurewebsites.net/
