using Demo.Framework.PageObject;
using OpenQA.Selenium;
namespace Demo.Framework.Action
{
    public class PaymentAndReviewActions
    {
        private readonly IWebDriver _driver;
        private readonly PaymentAndReviewPage _paymentAndReview = new PaymentAndReviewPage();

        public PaymentAndReviewActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterPaymentInformation()
        {
            _driver.FindElement(_paymentAndReview.CardNumber).SendKeys("4111111111111111");
            _driver.FindElement(_paymentAndReview.ExpiryDate).SendKeys("02");
            _driver.FindElement(_paymentAndReview.ExpiryDate).SendKeys("22"); //does not accept 4 digit expiration year
            _driver.FindElement(_paymentAndReview.CVV).SendKeys("123");
        }

        public void SubmitOrder()
        {
            _driver.FindElement(_paymentAndReview.SubmitOrder).Click();

        }
    }
}
