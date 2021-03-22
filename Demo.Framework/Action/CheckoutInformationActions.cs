using Demo.Framework.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demo.Framework.Action
{
    public class CheckoutInformationActions
    {
        private readonly IWebDriver _driver;
        private readonly CheckoutInformationPage _checkoutInformationPage = new CheckoutInformationPage();

        public CheckoutInformationActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void FillOutDefaultInformation()
        {
            _driver.FindElement(_checkoutInformationPage.EmailAddress).SendKeys("semrayozturk@gmail.com");
            _driver.FindElement(_checkoutInformationPage.FirstName).SendKeys("Semra");
            _driver.FindElement(_checkoutInformationPage.LastName).SendKeys("Yilmaz");
            _driver.FindElement(_checkoutInformationPage.PhoneNumber).SendKeys("1231232211");
            _driver.FindElement(_checkoutInformationPage.Address).SendKeys("1111 W Heathwood");
            _driver.FindElement(_checkoutInformationPage.City).SendKeys("Niles");
            _driver.FindElement(_checkoutInformationPage.ZipCode).SendKeys("60714");
            SelectElement stateDropDown = new SelectElement(_driver.FindElement(_checkoutInformationPage.State));
            stateDropDown.SelectByValue("IL");

        }

        public void ContinueToShippingMethod()
        {
            _driver.FindElement(_checkoutInformationPage.ContinueToShipping).Click();

        }
    }
}
