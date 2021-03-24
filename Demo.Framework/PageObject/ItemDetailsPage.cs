using OpenQA.Selenium;

namespace Demo.Framework.PageObject
{
    public class ItemDetailsPage
    {
        public By AddToCartBtn = By.Id("pnlAddToCart");
        public By ViewCart = By.XPath("//a[contains(text(), 'View Cart')]");
        public By AddedToCartModal = By.CssSelector("div.modal-callback");      

    }
}
