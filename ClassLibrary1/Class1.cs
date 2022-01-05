using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://login.yahoo.com/";

            IWebElement emailInputField = driver.FindElement(By.Id("login-username"));
        emailInputField.SendKeys("Labas@Labas.lt");

    }
}
