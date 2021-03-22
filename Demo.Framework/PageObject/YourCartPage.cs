using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class YourCartPage
    {
        public By Quantity = By.Id("rptRecipients_ctl00_rptCart_ctl00_txtQty");
        public By SecureCheckout = By.Id("btnCheckout");
    }
}
