using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Skaiciuokles.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;
        public IWebElement CoockiesAgree => Driver.FindElement(By.Id("edit-agree"));

        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));

            return wait;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
          public void ClearField(IWebElement element)
        {
            element.Click();
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
        }
    }
}