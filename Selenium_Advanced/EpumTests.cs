
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Advanced
{
    public class EpumTests
    {
        private IWebDriver _chrome;

        private const string MainPage = "https://www.epam.com/";

        private WebDriverWait Waiter { get; set; }

        private TimeSpan _timeout = TimeSpan.FromSeconds(5);
        private IJavaScriptExecutor? Jse { get; set; }

        [SetUp]
        public void Setup()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
            Waiter = new WebDriverWait(_chrome, TimeSpan.FromSeconds(15));
            _chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _chrome.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _chrome.Navigate().GoToUrl(MainPage);
            Jse = _chrome as IJavaScriptExecutor;
        }

        [SetUp]
        public void SetupWaiter()
        {
            Waiter = new WebDriverWait(_chrome, _timeout);
            Waiter.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

        }

        [Test]
        public void CheckEpamJobListingsIsOpen()
        {
            var action = new Actions(_chrome);
            var careersElement = _chrome.FindElement(By.XPath("//*[@class='top-navigation__item-link'][@href='/careers']"));
            action.MoveToElement(careersElement).Build().Perform();

            var jobListingsElement = _chrome.FindElement
            (By.XPath("//*[@class='top-navigation__main-link'][@href='/careers/job-listings']"));
            action.MoveToElement(jobListingsElement).Build().Perform();
            jobListingsElement.Click();

            Assert.That(_chrome.Url, Is.EqualTo("https://www.epam.com/careers/job-listings"),
            "There is another link for Listings page.");
        }


        [Test]
        public void CheckListOfLanguages()
        {
            var action = new Actions(_chrome);

            string[] expectedListOfLanguages =
             {
                "Global (English)",
                "Hungary (English)",
                "СНГ (Русский)",
                "Česká Republika (Čeština)",
                "India (English)",
                "Україна (Українська)",
                "Czech Republic (English)",
                "日本 (日本語)",
                "中国 (中文)",
                "DACH (Deutsch)",
                "Polska (Polski)"
            };

            Waiter.Until(Driver => Driver.FindElement(By.XPath("//*[@class='location-selector__button']"))).Click();

            var actualListOfLanguages =
            Waiter.Until(Driver => Driver.FindElements(By.XPath("//*[@class='location-selector__item']")))
            .Select(item => item.GetAttribute("innerText"));

            Assert.That(expectedListOfLanguages, Is.EqualTo(actualListOfLanguages), "Incorrect list of languages.");
        }


        [Test]
        public void Check20SearchResults()
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

            var requestSelection = _chrome.FindElement(By.XPath("//*[@class='frequent-searches__item' and contains(text(), 'Automation')]"));
            requestSelection.Click();

            var searchClick = _chrome.FindElement(By.XPath("//*[@class='header-search__submit']"));
            searchClick.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)_chrome;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            var articleElements = _chrome
            .FindElements(By.XPath("//*[@class='search-results__items']/article"))
            .Take(20);
            var articleElementsContent = articleElements.Select(x => x.Text);

            Assert.True(articleElementsContent.All(x => x.Contains("Automation", StringComparison.OrdinalIgnoreCase)));

            // var findview = _chrome.FindElement(By.XPath("//*[@class='search-results__view-more']"));
            //findview.Click(); 

            // var actualAmountOfFoundResults = _chrome.FindElements(By.XPath("//*[@class='search-results__item']"));
            // Assert.That(actualAmountOfFoundResults, Has.Count.EqualTo(20), "There are not 20 found result on the one page.");
        }

        [TearDown]
        public void TearDown()
        {
            _chrome.Quit();
        }
    }
}
