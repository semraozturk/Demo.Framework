using Demo.Framework.PageObject;
using Demo.Framework.Utils;
using OpenQA.Selenium;

namespace Demo.Framework.Action
{
    public class SearchResultsActions
    {
        private readonly IWebDriver _driver;
        private readonly SearchResultsPage _searchResultsPage = new SearchResultsPage();
        private readonly WaitUtils _waitUtils = new WaitUtils();

        public SearchResultsActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SelectTheSecondItem()
        {
            _waitUtils.WaitAndClick(_driver, _searchResultsPage.SecondItem);
        }
    }
}
