using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
     class DemoqaTestBoxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demoqa.com/text-box";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void FullNameTextBoxTest()
        {
            DemoqaTextBoxPage demoqaTextBoxPage = new DemoqaTextBoxPage(_driver);

            string text = "Arnas";

            demoqaTextBoxPage.InsertTextToFullNameField(text);
            demoqaTextBoxPage.ClickSubmitButton();
            demoqaTextBoxPage.VerifyFullNameResult(text);

        }

    }
}
