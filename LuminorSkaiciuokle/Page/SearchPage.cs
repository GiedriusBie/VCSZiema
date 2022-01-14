using NUnit.Framework;
using OpenQA.Selenium;

namespace Skaiciuokles.Page
{
    internal class SearchPage : BasePage
    {
        private const string PageAddress = "https://www.luminor.lt/";
        private IWebElement SearchButton => Driver.FindElement(By.CssSelector(".menu__item [aria-label='Search']"));
        private IWebElement SearchInput => Driver.FindElement(By.Id("edit-keys-2"));
        private IWebElement SearchSubmit => Driver.FindElement(By.Id("edit-submit-2"));
        private IWebElement Result => Driver.FindElement(By.ClassName("title"));
        public SearchPage(IWebDriver webdriver) : base(webdriver) { }

        public SearchPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public SearchPage ClickSearchButton()
        {
            SearchButton.Click();

            return this;
        }

        public SearchPage EnterSearchInputField(string searchValue)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(searchValue);

            return this;
        }

        public SearchPage ClickSearchSumbitButton()
        {
            SearchSubmit.Click();

            return this;
        }

        public SearchPage VerifyResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, Result.Text, $"Search result is incorect. Expected result is {expectedResult}");

            return this;
        }
    }
}
