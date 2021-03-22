using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class PaymentAndReviewPage
    {
        public By CardNumber = By.Id("CT_Main_1_txtCardNumber");
        public By ExpiryDate = By.Id("txtExpiryDate");
        public By CVV = By.Id("CT_Main_1_txtCVV");
        public By SubmitOrder = By.Id("btnPayment2");
    }
}
