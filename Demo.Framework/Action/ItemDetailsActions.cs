using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Demo.Framework.Action
{
    public class ItemDetailsActions
    {
        private readonly IWebDriver _driver;
        private readonly ItemDetailsPage _itemDetailsPage = new ItemDetailsPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();
        private readonly InteractionUtils _interactionUtils = new InteractionUtils();
        private readonly ScreenshotUtils _screenshotUtils = new ScreenshotUtils();
       

        public ItemDetailsActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AddToCart()
        {
            var element = _interactionUtils.ScrollToElement(_driver, _itemDetailsPage.AddToCartBtn);
            element.Click();
 
        }

        public void ViewCart(string path)
        {
            var viewCartElement = _waitUtils.WaitUntilElementIsClickable(_driver, _itemDetailsPage.ViewCart);
            Thread.Sleep(2000);
           _screenshotUtils.TakeScreenshotOfModal(_driver, _driver.FindElement(_itemDetailsPage.AddedToCartModal),path);
            viewCartElement.Click();
        }

    }
}
