using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class ItemDetailsActions
    {
        private readonly IWebDriver _driver;
        private readonly ItemDetailsPage _itemDetailsPage = new ItemDetailsPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();
        private readonly InteractionUtils _interactionUtils = new InteractionUtils();

        public ItemDetailsActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AddToCart()
        {
            var element = _interactionUtils.ScrollToElement(_driver, _itemDetailsPage.AddToCartBtn);
            element.Click();
        }

        public void ViewCart()
        {
            var viewCartElement = _waitUtils.WaitUntilElementIsClickable(_driver, _itemDetailsPage.ViewCart);
            viewCartElement.Click();
        }
    }
}
