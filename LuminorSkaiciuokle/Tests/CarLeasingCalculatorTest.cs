using NUnit.Framework;

namespace Skaiciuokles.Tests
{
    class CarLeasingCalculatorWhitResiduaValueTest : TestBase
    {
        [Test]
        public static void MonthlyPaymentForCarWithResidualValueTest()
        {
            carLeasingCalculatorPage.NavigateToDefaultPage()
                .ClickLeasingWithResidualValue()
                .EnterPrice("100000")
                .EnterDownPayment("15000")
                .EnterLeasingPeriod("48")
                .EnterResidualValue("30000")
                .VerifyMonthlySummaryPrice("1 290");
        }      
        
        [Test]
        public static void MonthlyPaymentForCarTest()
        {
             carLeasingCalculatorPage.NavigateToDefaultPage()
                .ClickLeasingValue()
                .EnterPrice("55000")                    
                .EnterDownPayment("13500")
                .EnterLeasingPeriod("12")
                .VerifyMonthlySummaryPrice("3 516");
        }
    }
}

