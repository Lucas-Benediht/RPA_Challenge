using RpaChallenge.Interfaces;
using OfficeOpenXml;
using System.IO;
using RpaChallenge.Models;

namespace RpaChallenge.Services
{
    public class ExcelService : IExcelService
    {
        public ExcelData[] ReadExcelData(string filePath)
        {
            using var package = new ExcelPackage(new FileInfo(filePath));
            var worksheet = package.Workbook.Worksheets[0];
            var rowCount = worksheet.Dimension.End.Row;

            var excelDataList = new List<ExcelData>();

            for (int row = 2; row <= rowCount; row++)
            {
                var firstNameCell = worksheet.Cells[row, 1].Value;

                if (firstNameCell == null || string.IsNullOrWhiteSpace(firstNameCell.ToString()))
                {
                    break;
                }

                var excelData = new ExcelData()
                {
                    FirstName = worksheet.Cells[row, 1].Value?.ToString() ?? string.Empty,
                    LastName = worksheet.Cells[row, 2].Value?.ToString() ?? string.Empty,
                    CompanyName = worksheet.Cells[row, 3].Value?.ToString() ?? string.Empty,
                    RoleInCompany = worksheet.Cells[row, 4].Value?.ToString() ?? string.Empty,
                    Address = worksheet.Cells[row, 5].Value?.ToString() ?? string.Empty,
                    Email = worksheet.Cells[row, 6].Value?.ToString() ?? string.Empty,
                    PhoneNumber = worksheet.Cells[row, 7].Value?.ToString() ?? string.Empty
                };
                excelDataList.Add(excelData);
            }
            return excelDataList.ToArray();
        }
    }
}
