using Demo.Framework.PageObject;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class HomePageActions
    {
        private readonly IWebDriver _driver;
        private readonly HomePage _homePage = new HomePage();

        public HomePageActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl("https://tequipment-staging.idevdesign.net/");
        }

        public void SearchForAnItem(string item)
        {
            _driver.FindElement(_homePage.SearchBox).SendKeys(item);
           
        }
    }
}
