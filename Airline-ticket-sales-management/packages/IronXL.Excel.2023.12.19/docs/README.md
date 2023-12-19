![Nuget](https://img.shields.io/nuget/v/IronXL.Excel?color=informational&label=latest)  ![Installs](https://img.shields.io/nuget/dt/IronXL.Excel?color=informational&label=installs&logo=nuget)  ![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%202425%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)  [![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)](https://ironsoftware.com/csharp/excel/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)](https://ironsoftware.com/csharp/excel/docs/questions/macos?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)](https://ironsoftware.com/csharp/excel/docs/questions/linux?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)](https://ironsoftware.com/csharp/excel/docs/questions/docker-support?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)](https://ironsoftware.com/csharp/excel/docs/questions/aws-lambada-support?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)](https://ironsoftware.com/csharp/excel/docs/questions/azure-support?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![livechat](https://img.shields.io/badge/Live%20Chat-Active-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

# IronXL - The C# Excel Library


[![IronXL NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronXL-readme/nuget-trial-banner-large.png)](https://ironsoftware.com/csharp/excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

[Get Started](https://ironsoftware.com/csharp/excel/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Features](https://ironsoftware.com/csharp/excel/features/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Code Examples](https://ironsoftware.com/csharp/excel/examples/read-excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Licensing](https://ironsoftware.com/csharp/excel/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Free Trial](https://ironsoftware.com/csharp/excel/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation#trial-license)

IronXL is a library developed and maintained by Iron Software that helps C# Software Engineers to read, generate and edit Excel (and other Spreadsheet files) in .NET applications & websites.

IronXL is a fast and natural approach to work with Excel and Other Spreadsheet files in C# within .NET. With no utilization of Office Excel Interopm IronXL works well with .NET Framework, .NET Core and Azure. All without extra dependencies or the need to install MS Office.

### IronXL excels at:
- Import Data from XLS/XLSX/CSV/TSV.
- Export Work Sheets to XLS/XLSX/CSV/TSV/JSON.
- Encrypt and decrypt XLSX/XLSM/XLTX files with passwords.
- Work with Spreadsheets as System.Data.DataSet and System.Data.DataTable objects.
- Excel Formulas recalculated every time a sheet it edited.
- Intuitive Ranges setting with a WorkSheet["A1:B10"] syntax.
- Sort Ranges, Columns and Rows.
- Style Cells - Font, Size, Background pattern, Border, Alignment and Number formats.

#### Document Formats
- Load, Read and Edit Data: XLS, XLSX, XLST, XLSM, CSV and TSV
- Saving and Exporting: XLS, XLSX, XLST, XLSM, CSV, TSV and JSON
- System.Data Objects: Work with Excel Spreadsheets as System.Data.DataSet and System.Data.DataTable

#### Sheet Functions
- Formulas: Works with Excel formulas and formulas recalculated every time a sheet it edited
- Cell Data Formats: Text, Number, Formulas, Dates, Currency, Percentage, Scientific, Time and Custom Formats
- Sorting: Ranges, Columns and Rows
- Cell Styling: Font, Size, Background pattern, Border and Alignment

### IronXL has cross platform support compatibility with:
- **.NET 6** and .NET 5, .NET Core, Standard, and Framework
- Windows, macOS, Linux, Docker, Azure, and AWS

[![IronXL Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronXL-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/excel/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

Additionally, our [API reference](https://ironsoftware.com/csharp/excel/object-reference/api/) and [full licensing information](https://ironsoftware.com/csharp/excel/licensing/#trial-license) can easily be found on our website.

### Using IronXL
Installing the IronXL NuGet package is quick and easy, please install the package like this:
```
PM> Install-Package IronXL.Excel
```
Once installed, you can get started by adding `using IronXL` to the top of your C# code. Here is an example to get started:
```csharp
using IronXL;
using System.Linq;
    
//Supported spreadsheet formats for reading include: XLSX, XLS, CSV and TSV
WorkBook workbook = WorkBook.Load("test.xlsx");
WorkSheet sheet = workbook.WorkSheets.First();

//Select cells easily in Excel notation and return the calculated value
int cellValue = sheet["A2"].IntValue;

// Read from Ranges of cells elegantly.
foreach (var cell in sheet["A2:A10"])
{
	Console.WriteLine("Cell {0} has value '{1}'", cell.AddressString, cell.Text);
}

//Calculate aggregate values such as Min, Max and Sum
decimal sum = sheet["A2:A10"].Sum();

//Linq compatible
decimal max = sheet["A2:A10"].Max(c => c.DecimalValue);
```

## Features Table
[![IronXL Features Table](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronXL-readme/features-table.png)](https://ironsoftware.com/csharp/excel/features/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

## Licensing & Support available
For code examples, tutorials and documentation visit [https://ironsoftware.com/csharp/excel/](https://ironsoftware.com/csharp/excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)

For support please email us at developers@ironsoftware.com 

## Documentation Links

-   Code Examples : [(https://ironsoftware.com/csharp/excel/examples/](https://ironsoftware.com/csharp/excel/examples/read-excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   API Reference : [https://ironsoftware.com/csharp/excel/object-reference/api/](https://ironsoftware.com/csharp/excel/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   Tutorials : [https://ironsoftware.com/csharp/excel/tutorials/how-to-read-excel-file-csharp/](https://ironsoftware.com/csharp/excel/tutorials/how-to-read-excel-file-csharp/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   Licensing : [https://ironsoftware.com/csharp/excel/licensing/](https://ironsoftware.com/csharp/excel/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
- Live Chat Support : [https://ironsoftware.com/csharp/excel/#helpscout-support](https://ironsoftware.com/csharp/excel/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)

You can email us at developers@ironsoftware.com for support directly from our code team. We offer licensing and extensive support for commercial deployment projects.
