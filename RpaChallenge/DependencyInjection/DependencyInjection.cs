using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using RpaChallenge.Interfaces;
using RpaChallenge.Services;

public static class DependencyInjection
{
    public static IServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddSingleton<IWebDriver>(new ChromeDriver());
        serviceCollection.AddTransient<IExcelService, ExcelService>();
        serviceCollection.AddTransient<IWebFormService, WebFormService>();

        return serviceCollection.BuildServiceProvider();
    }
}