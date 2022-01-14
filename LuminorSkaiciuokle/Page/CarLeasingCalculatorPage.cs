using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Skaiciuokles.Page
{
    internal class CarLeasingCalculatorPage : BasePage
    {
        private const string PageAddress = "https://www.luminor.lt/lt/privatiems/auto-lizingas#tabblock";
        private IWebElement LeasingWhitResidualValue => Driver.FindElement(By.CssSelector("[for= 'edit-type-flres']"));
        private IWebElement Price => Driver.FindElement(By.Id("edit-purchase-price"));
        private IWebElement DownPayment => Driver.FindElement(By.Id("edit-down-payment"));
        private IWebElement DownPaymentPercentge => Driver.FindElement(By.Id("edit-down-payment-percentage"));
        private IWebElement LeasingPeriod => Driver.FindElement(By.Id("edit-leasing-period"));
        private IWebElement InterestRate => Driver.FindElement(By.Id("edit-interest-rate"));
        private IWebElement MonthlySummaryPrice => Driver.FindElement(By.Id("monthly_summary_price"));
        private IWebElement LeasingValue => Driver.FindElement(By.CssSelector("[for = 'edit-type-fl']"));
        private IWebElement ResidualValue => Driver.FindElement(By.Id("edit-residual-value"));

        public CarLeasingCalculatorPage(IWebDriver webdriver) : base(webdriver) { }

        public CarLeasingCalculatorPage NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
            if (IsElementPresent(By.Id("edit-agree")))
            {
                CoockiesAgree.Click();
            }
            return this;
        }

        public CarLeasingCalculatorPage ClickLeasingValue()
        {
            LeasingValue.Click();

            return this;
        }

        public CarLeasingCalculatorPage ClickLeasingWhitResidualValue()
        {
            LeasingWhitResidualValue.Click();

            return this;
        }
        public CarLeasingCalculatorPage EnterResidualValue(string residualvalue)
        {
            ClearField(ResidualValue);
            ResidualValue.SendKeys(residualvalue);

            return this;
        }
        public CarLeasingCalculatorPage EnterPrice(string price)
        {
            ClearField(Price);
            Price.SendKeys(price);

            return this;
        }

        public CarLeasingCalculatorPage EnterDownPayment(string downPayment)
        {
            ClearField(DownPayment);
            DownPayment.SendKeys(downPayment);

            return this;
        }
        public CarLeasingCalculatorPage EnterDownPaymentPercentge(string downPaymentPercentge)
        {
            ClearField(DownPaymentPercentge);
            DownPaymentPercentge.SendKeys(downPaymentPercentge);

            return this;
        }
        public CarLeasingCalculatorPage EnterLeasingPeriod(string leasingPeriod)
        {
            ClearField(LeasingPeriod);
            LeasingPeriod.SendKeys(leasingPeriod);

            return this;
        }
        public CarLeasingCalculatorPage EnterInterestRate(string interestRate)
        {
            ClearField(InterestRate);
            InterestRate.SendKeys(interestRate);

            return this;
        }
        public CarLeasingCalculatorPage EnterMonthlySummaryPrice(string monthlySummaryPrice)
        {
            ClearField(MonthlySummaryPrice);
            MonthlySummaryPrice.SendKeys(monthlySummaryPrice);

            return this;
        }

        public CarLeasingCalculatorPage VerifyMonthlySummaryPrice(string expectedResult)
        {
            Assert.AreEqual(expectedResult, MonthlySummaryPrice.Text, $"Monhly payment amount result is incorect. Expected result is {expectedResult}");

            return this;
        }
        private void ClearField(IWebElement element)
        {
            element.Click();
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
        }


    }
}
