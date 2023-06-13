using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechnicalProject.Tests.Pages;


namespace TechnicalProject.Tests
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }
        public IList<IWebElement> results;
    }

}