using NUnit.Framework;

namespace Skaiciuokles.Tests
{
    class SearchTest : TestBase
    {
        [Test]
        public static void SearchForCalculatorsTest()
        {
            searchPage.NavigateToDefaultPage()
                .ClickSearchButton()
                .EnterSearchInputField("skaiciuokles")
                .ClickSearchSumbitButton()
                .VerifyResult("Pensijų skaičiuoklė");
        }
    }
}
