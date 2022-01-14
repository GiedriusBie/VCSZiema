using NUnit.Framework;

namespace Skaiciuokles.Tests
{
    class LoanCalculatorTest : TestBase
    {
        [Test]
        public static void MonthlyPaymentTest()
        {
            loanCalculatorPage.NavigateToDefaultPage()
                .EnterDealAmount("100000")
                .EnterDownPayment("25000")
                .EnterLoanTerm("20")
                .VerifyMonthlyResult("387");     
        }

        [Test]
        public static void MaxAmountTest()
        {
            loanCalculatorPage.NavigateToDefaultPage()
                .ClickBorrowingTab()
                .ClickNumberOfBorrowers()
                .EnterFamilyMonthlyIncome("4000")
                .EnterFamilyMonthlyPaymentForLiabilities("400")
                .EnterFamilyTotalLiabilities("20000")
                .SelectAmountOfDependants("2")
                .VerifyMaxLoanResult("234 175");
        }
    }
}
