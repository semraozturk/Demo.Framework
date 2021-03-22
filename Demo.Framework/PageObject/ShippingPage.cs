using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class ShippingPage
    {
        public By ThreeDayShipping = By.Id("ShippingMethodId_0_2");
        public By AddSignatureRequired = By.Id("chkShippingSignature0");
        public By ContinueToPaymentMethod = By.Id("btnShipping0");
    }
}
