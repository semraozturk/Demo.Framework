using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Demo.Framework.Utils
{
    public class InteractionUtils
    {
        private readonly WaitUtils _waitUtils = new WaitUtils();

        public IWebElement ScrollToElement(IWebDriver driver, By locator)
        {
            var element = _waitUtils.WaitUntilElementIsVisible(driver, locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,400)", "");
            return element;
        }

        public void ClearAndSendKeys(IWebDriver driver, IWebElement element, string text)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().
                SendKeys(Keys.Delete).
                SendKeys(text).
                SendKeys(Keys.Enter).Perform();
            Thread.Sleep(1000);
        }

        public void DoubleClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).DoubleClick().Perform();
        }
    }
}
