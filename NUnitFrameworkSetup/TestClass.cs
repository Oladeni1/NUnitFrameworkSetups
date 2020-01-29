// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitFrameworkSetup
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void LunchBrowser()
        {
            //Open website
            driver.Navigate().GoToUrl("https://www.udemy.com/");
        }
        [Test]
        public void RunTest()
        {
          //Write all your tests 
        }

        [TearDown]
        public void TearDown()
        {
            //Close browser session
            driver.Close();
        }
    }
}
