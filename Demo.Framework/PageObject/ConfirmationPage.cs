using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class ConfirmationPage
    {
        public By OrderNumber = By.XPath("//div[@id='order-confirmation']//descendant::span[@class='text-success']");
    }
}
