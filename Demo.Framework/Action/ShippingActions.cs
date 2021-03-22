using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class ShippingActions
    {
        private readonly IWebDriver _driver;
        private readonly ShippingPage _shippingPage = new ShippingPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();

        public ShippingActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SelectThreeDayShipping()
        {
            _waitUtils.WaitAndClick(_driver, _shippingPage.ThreeDayShipping);
        }

        public void AddSignatureRequired()
        {
            _driver.FindElement(_shippingPage.AddSignatureRequired).Click();

        }

        public void ContinueToPaymentMethod()
        {
            _driver.FindElement(_shippingPage.ContinueToPaymentMethod).Click();

        }
    }
}
