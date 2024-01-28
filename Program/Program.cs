using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RpaChallenge.Interfaces;

public class Program
{
    static void Main()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        var serviceProvider = DependencyInjection.ConfigureServices();
        var excelService = serviceProvider.GetRequiredService<IExcelService>();
        var webFormService = serviceProvider.GetService<IWebFormService>();

        var excelFilePath = @"C:\Users\Benee\Downloads\challenge.xlsx";

        try
        {
            var excelData = excelService.ReadExcelData(excelFilePath);

            webFormService.FillWebForm(excelData);

            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
