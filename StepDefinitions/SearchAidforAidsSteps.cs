using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechnicalProject.Tests.Pages;
using TechnicalProject.Tests;
using TechTalk.SpecFlow;

namespace TechnicalProject.StepDefinitions
{
    [Binding]
    public class SearchAidforAidsSteps : DriverHelper
    {
        SearchAidforAidsPage searchAidForAidsO = new SearchAidforAidsPage();

        [Given(@"Open the Browser")]
        public void GivenOpenTheBrowser()
        {
            Driver = new ChromeDriver();
        }

        [When(@"Enter to Google")]
        public void WhenEnterToGoogle()
        {
            Driver.Url = "https://www.google.com/";
            Thread.Sleep(1000);
        }

        [When(@"Search for the Aid for Aids")]
        public void ThenSearchForTheAidForAids()
        {
            searchAidForAidsO.searchbar.Click();
            searchAidForAidsO.searchbar.SendKeys("Aid for Aids");
            searchAidForAidsO.searchbar.SendKeys(Keys.Enter);
        }

        [Then(@"close the test")]
        public void ThenCloseTheTest()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement checksearch = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gsr")));
            // Aquí puedes realizar las acciones adicionales que deseas después de que el elemento sea visible
            // ...
            Driver.Quit(); // Cierra el navegador al finalizar el test
        }

    }
}