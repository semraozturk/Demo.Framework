using Demo.Framework.Action;
using Demo.Framework.Core;
using Demo.Framework.Utils;
using NUnit.Framework;

namespace Demo.Framework.Test
{
    public class CheckoutTest : BaseTest
    {
        private static readonly ExtentReportUtils _extentReportUtils = new ExtentReportUtils();
        private static readonly ScreenshotUtils _screenshotUtils = new ScreenshotUtils();


        [Test]
        public void Test()
        {
            var extentTest = _extentReportUtils.StartTest(_report, "Checkout an item");
            var homePageActions = new HomePageActions(_webDriver);
            var searchResultsActions = new SearchResultsActions(_webDriver);
            var itemDetailsActions = new ItemDetailsActions(_webDriver);
            var cartActions = new YourCartActions(_webDriver);
            var checkoutInfoActions = new CheckoutInformationActions(_webDriver);
            var shippingActions = new ShippingActions(_webDriver);
            var paymentActions = new PaymentAndReviewActions(_webDriver);
            var confirmationActions = new ConfirmationActions(_webDriver);

            homePageActions.NavigateToHomePage();
            homePageActions.SearchForAnItem("fluke");
            searchResultsActions.SelectTheSecondItem();
            itemDetailsActions.AddToCart();
            //take a screenshot of the addtocart popup

            itemDetailsActions.ViewCart();
            cartActions.EnterQuantity("2");
            cartActions.Checkout();

            checkoutInfoActions.FillOutDefaultInformation();
            checkoutInfoActions.ContinueToShippingMethod();

            shippingActions.SelectThreeDayShipping();
            shippingActions.AddSignatureRequired();
            shippingActions.ContinueToPaymentMethod();

            paymentActions.EnterPaymentInformation();
            paymentActions.SubmitOrder();

            var confirmationNumber = confirmationActions.GetOrderNumber();
            var pathToTheScreenshot = _screenshotUtils.GetPathForScreenshot();
            _screenshotUtils.TakeAScreenshot(_webDriver, pathToTheScreenshot);
            Assert.That(confirmationNumber, Is.Not.Null);
            _ = extentTest.Log(AventStack.ExtentReports.Status.Info, $"Order Number: {confirmationNumber}").
                AddScreenCaptureFromPath(pathToTheScreenshot);
            _ = extentTest.Pass("Successfully checked out an item");
        }        
    }
}
