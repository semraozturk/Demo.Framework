using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class CheckoutInformationPage
    {
        public By EmailAddress = By.Id("CT_Main_1_txtEmail");
        public By FirstName = By.Id("txtShippingFirstName");
        public By LastName = By.Id("txtShippingLastName");
        public By PhoneNumber = By.Id("txtShippingPhone");
        public By Address = By.Id("txtShippingAddress1");
        public By City = By.Id("txtShippingCity");
        public By ZipCode = By.Id("txtShippingZip");
        public By State = By.Id("drpShippingState");
        public By ContinueToShipping = By.XPath("//span[text() = 'Continue to Shipping Method ']");
    }
}
