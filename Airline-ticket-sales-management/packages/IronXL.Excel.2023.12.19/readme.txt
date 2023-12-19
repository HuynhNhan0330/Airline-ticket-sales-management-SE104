IronXL is the Excel Library for .NET to read, generate and edit Excel (and other Spreadsheet files) in .NET projects. IronXL supports .NET 6, .NET 5, Core, Standard & Framework without the need to install MS Office or Excel Interop.

Visit our website for a quick-start guide at https://ironsoftware.com/csharp/excel/

C# Code Example:
========================
using IronXL;
WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
xlsWorkbook.Metadata.Author = "IronXL";
WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("new_sheet");
xlsSheet["A1"].Value = "Hello World";
xlsSheet["A2"].Style.BottomBorder.SetColor("#ff6600");
xlsSheet["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
xlsWorkbook.SaveAs("NewExcelFile.xls"); //Save the excel file

Documentation Links
========================
Code Examples : https://ironsoftware.com/csharp/excel/examples/read-excel/
API Reference : https://ironsoftware.com/csharp/excel/object-reference/
Tutorials : https://ironsoftware.com/csharp/excel/tutorials/how-to-read-excel-file-csharp/
Licensing : https://ironsoftware.com/csharp/excel/licensing/
Support : developers@ironsoftware.com

Compatibility
========================
* C#, F#, and VB.NET
* .NET 6, .NET 5, Core 2x & 3x, and Framework 4.6.2
* Console, Web, and Desktop Apps
* Windows, macOs, Linux, macOS, and Azure
* Microsoft Visual Studio or Jetbrains ReSharper & Rider
