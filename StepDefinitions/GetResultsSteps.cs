using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProject.Tests.Pages;
using TechTalk.SpecFlow;
using TechnicalProject.Tests;

namespace TechnicalProject.StepDefinitions
{
    [Binding]
    public class GetResultsSteps : DriverHelper
    {
        GetResultsPage getResultsO = new GetResultsPage();
        int count = 0;
        List<string> domainResults = new List<string>();

        [When(@"Get all search results")]
        public void WhenGetAllSearchResults()
        {
            var searchResultsList = Driver.FindElements(getResultsO.resultsList);
            List<string> listResults = new List<string>();

            foreach (var resultl in searchResultsList)
            {
                listResults.Add(resultl.Text);
            }


            foreach (var resultl in listResults)
            {
                Console.WriteLine(resultl);
            }
        }

        [When(@"Validate how many belong to the domain")]
        public void WhenValidateHowManyBelongToTheDomain()
        {
            var searchResults = Driver.FindElements(getResultsO.resultsDomList);
            domainResults.Clear();

            foreach (var resultd in searchResults)
            {
                domainResults.Add(resultd.Text);
            }

            foreach (var resultd in domainResults)
            {
                Console.WriteLine(resultd);
            }
        }

        [When(@"Validate that the search is greater than zero")]
        public void WhenValidateThatTheSearchIsGreaterThanZero()
        {
            if (domainResults.Count > 0)
            {
                Console.WriteLine("El resultado del dominio es mayor que cero.");
            }
            else
            {
                Console.WriteLine("El resultado del dominio es cero o no se encontraron resultados.");
            }
        }

        [Then(@"Finish the Test")]
        public void ThenFinishTheTest()
        {
            Console.WriteLine("Test finished successfully!");
            Driver.Quit();
        }
    }
}