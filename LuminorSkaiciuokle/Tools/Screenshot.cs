using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.IO;
using System.Reflection;

namespace Skaiciuokles.Tools
{
    class MyScreenshot
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            Screenshot screenshot = driver.TakeScreenshot();
            string screenshotDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            string screenshotFolder = Path.Combine(screenshotDirectory, "screenshot");
            Directory.CreateDirectory(screenshotFolder);

            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
            string screenshotPath = Path.Combine(screenshotFolder, screenshotName);

            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }
    }
}