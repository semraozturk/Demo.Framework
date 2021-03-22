using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;

namespace Demo.Framework.Utils
{
    public class ScreenshotUtils
    {
        public void TakeAScreenshot(IWebDriver driver, string path)
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

        public string GetPathForScreenshot()
        {
            var bin = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(bin, $"Report/{Guid.NewGuid()}");
        }
    }
}
