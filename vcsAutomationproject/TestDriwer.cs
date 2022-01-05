using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcsAutomationproject
{
    public class Class2
    {
        private static IWebDriver _Driver;
        

        [OneTimeSetUp]
        public void Setup()
        {
            _Driver = new ChromeDriver();
            _Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _Driver.Manage().Window.Maximize();
            _Driver.Url = "https://testpages.herokuapp.com/styled/calculator";

        }
        [OneTimeTearDown]
        public void Teardown()
        {
            _Driver.Close();
        }



        [Test]
        public static void TestChromeDriwer()
    {
            _Driver = new ChromeDriver();
            _Driver.Url = "https://login.yahoo.com/";
            
        }

      

        [Test]
        
        public static void TestYahooPage()
        {
            _Driver = new ChromeDriver();
            _Driver.Url = "https://login.yahoo.com/";

            IWebElement emailInputField = _Driver.FindElement(By.Id("login-username"));
            emailInputField.SendKeys("labas@Labas.lt");

            IWebElement submitButton = _Driver.FindElement(By.Id("login-signin"));
            submitButton.Click();
        }

        [Test]

        public static void TestInputPage()

        {
            _Driver = new ChromeDriver();
            _Driver.Url = "https://demoqa.com/text-box";
            IWebElement emailInputField = _Driver.FindElement(By.Id("userName"));
            emailInputField.SendKeys("Giedrius Bielinis");

            IWebElement submitButton = _Driver.FindElement(By.Id("submit"));
            submitButton.Click();

            IWebElement fullNameResult = _Driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:Giedrius Bielinis", fullNameResult.Text, "name is wrong");
        }

        
        [TestCase("2" , "2" , "4", TestName = "2 + 2 = 4")]

        public static void NamuDarbai1(string firstinputvalue, string secondInputValue, string expectedresult)
        {
            


            IWebElement firstinput = _Driver.FindElement(By.Id("number1"));
            IWebElement secondinput = _Driver.FindElement(By.Id("number2"));

            firstinput.SendKeys(firstinputvalue);
            secondinput.SendKeys(secondInputValue);

            IWebElement calculationButton = _Driver.FindElement(By.Id("calculate"));
            calculationButton.Click();

            IWebElement actualResult = _Driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedresult, actualResult.Text, "answer is wrong");
            
        }

        [Test]

        public static void NamuDarbai2()
        {
            _Driver = new ChromeDriver();
            _Driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement skaicius1 = _Driver.FindElement(By.Id("number1"));
            skaicius1.SendKeys("-5");
            IWebElement skaicius2 = _Driver.FindElement(By.Id("number2"));
            skaicius2.SendKeys("3");
            IWebElement calculate = _Driver.FindElement(By.Id("calculate"));
            calculate.Click();
            IWebElement Result = _Driver.FindElement(By.Id("answer"));
            Assert.AreEqual("-2", Result.Text, "ansver  is wrong");
            
        }
        [Test]

        public static void NamuDarbai3()
        {
            _Driver = new ChromeDriver();
            _Driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            IWebElement skaicius1 = _Driver.FindElement(By.Id("number1"));
            skaicius1.SendKeys("a");
            IWebElement skaicius2 = _Driver.FindElement(By.Id("number2"));
            skaicius2.SendKeys("b");
            IWebElement calculate = _Driver.FindElement(By.Id("calculate"));
            calculate.Click();
            IWebElement Result = _Driver.FindElement(By.Id("answer"));
            Assert.AreEqual("ab", Result.Text, "answer is wrong");
            
        }
    }
}


//}
//[OneTimeSetUp]
//public void SetUp()
//{
//    _driver = new ChromeDriver();
//    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//    _driver.Manage().Window.Maximize();
//    _driver.Url = "https://testpages.herokuapp.com/styled/calculator";
//}

//[OneTimeTearDown]
//public void TearDown()
//{
//    _driver.Close();
//}

//Baigiamojo darbo reikalavimai:

//Minimum 5 prasmingi testai(kiekvienas testas minimum 3 žingsniai)
//Minimum 3 skirtingi puslapiai(tas pats website)
//Page Object Pattern
//Screenshot on test failure
//Paveldėjimas
//SetUp / TearDown panaudojimas
//Darbas įkeltas į GIT
//Explicit Wait panaudojimas
