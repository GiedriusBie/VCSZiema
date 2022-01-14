using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Skaiciuokles.Page
{
    internal class LoanCalculatorPage : BasePage
    {
        private const string PageAddress = "https://www.luminor.lt/lt/privatiems/busto-paskolos-skaiciuokle";
        private IWebElement DealAmount => Driver.FindElement(By.Id("edit-deal-amount"));
        private IWebElement DownPayment => Driver.FindElement(By.Id("edit-down-payment"));
        private IWebElement LoanTerm => Driver.FindElement(By.Id("edit-loan-term"));
        private IWebElement PaymentAmounts => Driver.FindElement(By.ClassName("summary__price"));
        private IWebElement BorrowingTab => Driver.FindElement(By.LinkText("Kiek gali pasiskolinti?"));
        private IWebElement NumberOfBorrowers => Driver.FindElement(By.CssSelector("[for='edit-number-of-borrowers-2']"));
        private IWebElement FamilyMonthlyIncome => Driver.FindElement(By.Id("edit-family-monthly-income"));
        private IWebElement FamilyMonthlyPaymentForLiabilities => Driver.FindElement(By.Id("edit-family-monthly-payment-for-liabilities"));
        private IWebElement FamilyTotalLiabilities => Driver.FindElement(By.Id("edit-family-total-liabilities"));
        private IWebElement LoanAmount => Driver.FindElement(By.CssSelector(".max-credit-container .max-loan-amount"));
        private SelectElement DependantsDropDown => new SelectElement(Driver.FindElement(By.Id("edit-dependants")));

        public LoanCalculatorPage(IWebDriver webdriver) : base(webdriver) { }

        public LoanCalculatorPage NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
            if (IsElementPresent(By.Id("edit-agree")))
            {
                CoockiesAgree.Click();
            }
            return this;
        }

        public LoanCalculatorPage EnterDealAmount(string dealAmount)
        {
            ClearField(DealAmount);
            DealAmount.SendKeys(dealAmount);

           return this;
        }

        public LoanCalculatorPage EnterDownPayment(string downPaymen)
        {
            ClearField(DownPayment);
            DownPayment.SendKeys(downPaymen);
           
            return this;
        }

        public LoanCalculatorPage EnterLoanTerm(string loanTerm)
        {
            ClearField(LoanTerm);
            LoanTerm.SendKeys(loanTerm);

            return this;
        }

        public LoanCalculatorPage ClickBorrowingTab()
        {
            BorrowingTab.Click();

            return this;
        }

        public LoanCalculatorPage ClickNumberOfBorrowers()
        {
            NumberOfBorrowers.Click();

            return this;
        }

        public LoanCalculatorPage EnterFamilyMonthlyIncome(string familyMonthlyIncome)
        {
            ClearField(FamilyMonthlyIncome);
            FamilyMonthlyIncome.SendKeys(familyMonthlyIncome);

            return this;
        }
        public LoanCalculatorPage EnterFamilyMonthlyPaymentForLiabilities(string familyMonthlyPaymentForLiabilities)
        {
            ClearField(FamilyMonthlyPaymentForLiabilities);
            FamilyMonthlyPaymentForLiabilities.SendKeys(familyMonthlyPaymentForLiabilities);

            return this;
        }

        public LoanCalculatorPage EnterFamilyTotalLiabilities(string familyTotalLiabilities)
        {
            ClearField(FamilyTotalLiabilities);
            FamilyTotalLiabilities.SendKeys(familyTotalLiabilities);

            return this;
        }

        public LoanCalculatorPage SelectAmountOfDependants(string value)
        {
            DependantsDropDown.SelectByValue(value);

            return this;
        }

        public LoanCalculatorPage VerifyMonthlyResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, PaymentAmounts.Text, $"Monhly payment amount result is incorect. Expected result is {expectedResult}");

            return this;
        }

        public LoanCalculatorPage VerifyMaxLoanResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, LoanAmount.Text, $"Max loan result is incorect. Expected result is {expectedResult}");

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
