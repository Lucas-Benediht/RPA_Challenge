using OpenQA.Selenium;
using RpaChallenge.Interfaces;
using RpaChallenge.Models;

public class WebFormService : IWebFormService
{
    private readonly IWebDriver _driver;

    public WebFormService(IWebDriver driver)
    {
        _driver = driver;
    }

    public void FillWebForm(ExcelData[] excelData)
    {
        var urlDesafio = "https://rpachallenge.com/";
        _driver.Navigate().GoToUrl(urlDesafio);

        var botaoStart = _driver.FindElement(By.XPath("//button[contains(text(),'Start')]"));
        botaoStart.Click();

        foreach (var data in excelData)
        {
            FillField("labelFirstName", data.FirstName);
            FillField("labelLastName", data.LastName);
            FillField("labelCompanyName", data.CompanyName);
            FillField("labelRole", data.RoleInCompany);
            FillField("labelAddress", data.Address);
            FillField("labelEmail", data.Email);
            FillField("labelPhone", data.PhoneNumber);

            var botaoSubmit = _driver.FindElement(By.XPath("//input[@type='submit']"));
            botaoSubmit.Click();
        }
    }

    private void FillField(string fieldName, string value)
    {
        var field = _driver.FindElement(By.XPath($"//input[@ng-reflect-name='{fieldName}']"));
        field.SendKeys(value);
    }
}