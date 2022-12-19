using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Basics2
{
    public class EpumTests
    {
        private IWebDriver _chrome;

        private const string MainPage = "https://www.epam.com/";

        private WebDriverWait Waiter { get; set; }

        private TimeSpan _timeout = TimeSpan.FromSeconds(5);

        [SetUp]
        public void Setup()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
            _chrome.Navigate().GoToUrl(MainPage);
        }

        [SetUp]
        public void SetupWaiter()
        {
            Waiter = new WebDriverWait(_chrome, _timeout);
            Waiter.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        }

        [Test]
        public void CheckEpamCareersLocations()
        {
            string[] expectedOfficeLocations = { "AMERICAS", "EMEA", "APAC" };

            var action = new Actions(_chrome);

            var careersElement = _chrome.FindElement(By.XPath("//*[@href='/careers']"));
            action.MoveToElement(careersElement).Build().Perform();
            careersElement.Click();

            var ourOffices = _chrome.FindElement(By.XPath("//*[@class='tabs__ul js-tabs-links-list']"));
            Actions scrollDown = new Actions(_chrome);
            scrollDown.ScrollToElement(ourOffices).Build().Perform();

            var officeElements = ourOffices.FindElements(By.XPath(".//div/a"));
            Assert.That(officeElements.Count(), Is.EqualTo(3), "Invalid numder of offices");

            var officeLocations = officeElements.Select(x => x.Text).ToList();

            int i = 2;

            CollectionAssert.AreEquivalent(expectedOfficeLocations, officeLocations);
        }

        [Test]
        public void CheckSearchResultsContainSearchWord()
        {
            var action = new Actions(_chrome);

            var searchButton = _chrome.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
            searchButton.Click();

            var searchPanelDisplayedState = Waiter.Until(function =>
            {
                try
                {
                    var searchPanel =
                        _chrome.FindElement(By.XPath("//*[contains(@class, 'header-search__field no-focus')]"));
                    return searchPanel.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            Assert.IsTrue(searchPanelDisplayedState);

            var searchPanelClick = _chrome.FindElement(By.XPath("//*[@class='header-search__input frequent-searches__input']"));
            searchPanelClick.Click();
            searchPanelClick.SendKeys("Automation");

            var searchClick = _chrome.FindElement(By.XPath("//*[@class='header-search__submit']"));
            searchClick.Click();

            var wordToSearch = _chrome.Url.Replace("https://www.epam.com/search?q=", "");
            Assert.That(wordToSearch, Is.EqualTo("Automation"));

            var articleElements = _chrome
                .FindElements(By.XPath("//*[@class='search-results__items']/article"))
                .Take(5);

            var articleElementsContent = articleElements.Select(x => x.Text);

            Assert.True(articleElementsContent.All(x => x.Contains("Automation", StringComparison.OrdinalIgnoreCase)));
        }

        [Test]
        public void CheckSearchResultLinkTextIsTheSameAsArticleHeader()
        {
            var action = new Actions(_chrome);

            var searchButton = _chrome.FindElement(By.XPath("//*[@class='header-search__button header__icon']"));
            searchButton.Click();

            var searchPanelDisplayedState = Waiter.Until(function =>
            {
                try
                {
                    var searchPanel =
                        _chrome.FindElement(By.XPath("//*[contains(@class, 'header-search__field no-focus')]"));
                    return searchPanel.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            Assert.IsTrue(searchPanelDisplayedState);

            var searchPanelClick = _chrome.FindElement(By.XPath("//*[@class='header-search__input frequent-searches__input']"));
            searchPanelClick.Click();
            searchPanelClick.SendKeys("Business Analysis");

            var searchClick = _chrome.FindElement(By.XPath("//*[@class='header-search__submit']"));
            searchClick.Click();

            var wordToSearch = _chrome.Url.Replace("https://www.epam.com/search?q=", "");
            Assert.That(wordToSearch, Is.EqualTo("Business+Analysis"));

            var firstArticleElement = _chrome
                 .FindElements(By.XPath("//*[@class='search-results__items']/article"))
                 .First();

            var linkElement = firstArticleElement.FindElement(By.XPath("//h3/a"));
            var linkElementContent = linkElement.Text;
            var linkElementUrl = linkElement.GetAttribute("href");

            _chrome.Navigate().GoToUrl(linkElementUrl);

            var articleHeader = _chrome.FindElement(By.XPath("//h1"));
            var articleHeaderContent = articleHeader.Text;

            Assert.That(linkElementContent, Is.EqualTo(articleHeaderContent));
        }

        [TearDown]
        public void TearDown()
        {
            _chrome.Quit();
        }
    }
}

// 1. https://www.epam.com/ //span[contains(text(),'CONTACT')]//parent::a      ("Keyword contains and axis parent)
// li[@class='top-navigation__item epam']/following-sibling::li

// li[@class='hamburger-menu__item item--child'][last()]