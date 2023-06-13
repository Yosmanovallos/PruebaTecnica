using OpenQA.Selenium;

namespace TechnicalProject.Tests.Pages
{
    class SearchAidforAidsPage : DriverHelper
    {
        public IWebElement searchbar => Driver.FindElement(By.Name("q"));
        public IWebElement checksearch => Driver.FindElement(By.Id("gsr"));
    }
}