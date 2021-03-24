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
            var pathToTheScreenshot = _screenshotUtils.GetPathForScreenshot();
            var pathToTheScreenshot1 = _screenshotUtils.GetPathForScreenshot();

            homePageActions.NavigateToHomePage();
            homePageActions.SearchForAnItem("fluke");
            searchResultsActions.SelectTheSecondItem();
            itemDetailsActions.AddToCart();
            itemDetailsActions.ViewCart(pathToTheScreenshot);
            _ = extentTest.Log(AventStack.ExtentReports.Status.Info, "Modal screenshot captured").
               AddScreenCaptureFromPath(pathToTheScreenshot);

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
            _screenshotUtils.TakeAScreenshot(_webDriver, pathToTheScreenshot1);
           
            Assert.That(confirmationNumber, Is.Not.Null);
            _ = extentTest.Log(AventStack.ExtentReports.Status.Info, $"Order Number: {confirmationNumber}").
                AddScreenCaptureFromPath(pathToTheScreenshot1);
            _ = extentTest.Pass("Successfully checked out an item");

        }  
        


    }
}
