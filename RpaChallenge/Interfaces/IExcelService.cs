using RpaChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpaChallenge.Interfaces
{
    public interface IExcelService
    {
        ExcelData[] ReadExcelData(string filePath);
    }
}
