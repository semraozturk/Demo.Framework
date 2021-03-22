using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class ConfirmationActions
    {
        private readonly IWebDriver _driver;
        private readonly ConfirmationPage _confirmationPage = new ConfirmationPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();

        public ConfirmationActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetOrderNumber()
        {
            return _waitUtils.WaitUntilElementIsVisible(_driver, _confirmationPage.OrderNumber).Text;
        }
    }
}
