using Skaiciuokles.Page;
using Skaiciuokles.Tools;
using Skaiciuokles.Drivers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Skaiciuokles.Tests
{
    internal class TestBase
    {
        protected static IWebDriver Driver;
        public static SearchPage searchPage;
        public static LoanCalculatorPage loanCalculatorPage;
        public static CarLeasingCalculatorPage carLeasingCalculatorPage;


        [OneTimeSetUp]
        public void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            searchPage = new SearchPage(Driver);
            loanCalculatorPage = new LoanCalculatorPage(Driver);
            carLeasingCalculatorPage = new CarLeasingCalculatorPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Close();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}
