
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Advanced
{
    public class SeleniumTest
    {
        private IWebDriver _chrome;

        private const string MainPage = "https://www.epam.com/";

        private WebDriverWait Waiter { get; set; }

        private TimeSpan _timeout = TimeSpan.FromSeconds(5);
        protected Actions PageAction { get; private set; }


        [SetUp]
        public void Setup()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
            Waiter = new WebDriverWait(_chrome, TimeSpan.FromSeconds(15));
            _chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _chrome.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _chrome.Navigate().GoToUrl(MainPage);
            PageAction = new Actions(_chrome);
        }

        [SetUp]
        public void SetupWaiter()
        {
            Waiter = new WebDriverWait(_chrome, _timeout);
            Waiter.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

        }

        [Test]
        public void CheckIfHeaderPresentOnThePageTest()
        {
            var isHeaderDisplayed = _chrome.FindElement(By.XPath("//*[@class='header__content']")).Displayed;
            Assert.That(isHeaderDisplayed, Is.True, "Header is not displayed on the page.");
        }

        [Test]
        public void CheckUrl()
        {
            var expectedResult = "https://www.epam.com/careers/locations";
            PageAction.MoveToElement(Waiter.Until(Driver =>Driver.FindElement
            (By.XPath("//*[@class='top-navigation__item-link' and contains(@href, '/careers')]"))))
            .Build()
            .Perform();

            Waiter.Until(Driver =>Driver.FindElement
            (By.XPath("//*[@class='top-navigation__main-link' and contains(@href, '/careers/locations')]")))
            .Click();
            Assert.That(_chrome.Url, Is.EqualTo(expectedResult),
            $"Url doesn't {expectedResult}");
        }

        [Test]
        public void CheckButtonOnPageTest()
        {
            PageAction.MoveToElement(Waiter.Until(Driver =>Driver.FindElement
            (By.XPath("//*[@class='top-navigation__item-link' and contains(@href, '/careers')]"))))
            .Build()
            .Perform();

            Waiter.Until(Driver =>Driver.FindElement
            ( By.XPath("//*[@class='top-navigation__main-link' and contains(@href, '/careers/locations')]")))
            .Click();
            PageAction.MoveToElement(Waiter.Until(Driver =>Driver
            .FindElement(By.XPath(" //*[@class='footer__brands-list-wrapper']"))))
            .Build()
            .Perform();
            var isApplyButtonVisible =
            _chrome.FindElement(By.XPath("//*[@class='button__content button__content--desktop']")).Displayed;
            Assert.That(isApplyButtonVisible, Is.True, "Apply button not on page");
        }

        [TearDown]
        public void TearDown()
        {
            _chrome.Quit();
        }
    }
}

