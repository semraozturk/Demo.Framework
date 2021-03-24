using System.Threading;
using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class YourCartActions
    {
        private readonly IWebDriver _driver;
        private readonly YourCartPage _cartPage = new YourCartPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();
        private readonly InteractionUtils _interactionUtils = new InteractionUtils();

        public YourCartActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterQuantity(string quantity)
        {
            var quantityField = _waitUtils.WaitUntilElementIsVisible(_driver, _cartPage.Quantity);
            _interactionUtils.ClearAndSendKeys(_driver, quantityField, quantity);
        }

        public void Checkout()
        {
            _interactionUtils.ScrollToElement(_driver, _cartPage.SecureCheckout);
            var element = _waitUtils.WaitUntilElementIsVisible(_driver, _cartPage.SecureCheckout);
            _interactionUtils.DoubleClick(_driver, element);
            Thread.Sleep(3000);
            
        }
    }
}
