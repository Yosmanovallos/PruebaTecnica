using OpenQA.Selenium;


namespace TechnicalProject.Tests.Pages
{
    class GetResultsPage : DriverHelper
    {
        public By resultsDomList = By.XPath("//cite[contains(text(),'https://aidforaids.org') and contains(@class, 'apx8Vc qLRx3b tjvcx GvPZzd cHaqb')]");
        public By resultsList = By.XPath("//h3[contains(text(),'AID FOR AIDS') and contains(@class, 'LC20lb MBeuO DKV0Md')]");
    }
}
