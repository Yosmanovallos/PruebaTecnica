using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using TechnicalProject.Tests.Pages;
using TechTalk.SpecFlow;
using TechnicalProject.Tests;

namespace TechnicalProject.StepDefinitions
{
    [Binding]
    public class SmokeAidofAidsSteps : DriverHelper
    {
        SmokeAidofAidsPage smokeAidofAidsO = new SmokeAidofAidsPage();
        GetResultsPage getResultsO = new GetResultsPage();
        int count = 0;
        List<string> whowearetitle = new List<string>();

        [When(@"Smoke test into the page")]
        public void WhenSmokeTestIntoThePage()
        {
            Thread.Sleep(4000);
            smokeAidofAidsO.resultDomclick.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement checktitle = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("afl")));

            smokeAidofAidsO.whoWeAreButton.Click();
            WebDriverWait waittwo = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement whowearetitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[@class='fancy-title entry-title start-animation-done start-animation']")));
        }

        [Then(@"Finish the smoke test")]
        public void ThenFinishTheSmokeTest()
        {
            if (whowearetitle.Count > 1)
            {
                Console.WriteLine("Smoke test passed!");
                return;
            }
            throw new Exception("Smoke test failed!");
        }
    }
}