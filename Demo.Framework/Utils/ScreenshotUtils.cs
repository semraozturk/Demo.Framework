using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;

namespace Demo.Framework.Utils
{
    public class ScreenshotUtils
    {
        public string GetPathForScreenshot()
        {
            var bin = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(bin, $"Report/{Guid.NewGuid()}");
        }

        public void TakeAScreenshot(IWebDriver driver, string path)
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

        public void TakeScreenshotOfElement(IWebDriver driver, IWebElement element, string path)
        {
            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));
            Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width + 900, element.Size.Height + 500);
            screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
            screenshot.Save(String.Format(path, ScreenshotImageFormat.Png));
        }


        public void TakeScreenshotOfModal(IWebDriver driver, IWebElement element, string path)
        {
            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));
            Rectangle croppedImage = new Rectangle(element.Location.X + 530, element.Location.Y - 750, element.Size.Width + 1200, element.Size.Height + 1200);
            screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
            screenshot.Save(String.Format(path, ScreenshotImageFormat.Png));
        }





    }
}
