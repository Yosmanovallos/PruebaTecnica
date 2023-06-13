using OpenQA.Selenium;


namespace TechnicalProject.Tests.Pages
{
    class SmokeAidofAidsPage : DriverHelper
    {

        public IWebElement resultDomclick = Driver.FindElement(By.XPath(""));
        public By titleAidofAid = By.Id("afl");
        public IWebElement whoWeAreButton = Driver.FindElement(By.XPath("//span[contains(@class, 'menu-item-text') and span[@class='menu-text' and text()='Who we are']][1]"));
        public By whoWeAretitle = By.XPath("//h1[@class='fancy-title entry-title start-animation-done start-animation']");

    }
}