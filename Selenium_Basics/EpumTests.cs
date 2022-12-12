using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Basics
{
    public class EpumTests
    {
        private IWebDriver _chrome;

        private const string MainPage = "https://www.epam.com/";

        private const string HowWeDoItPage = "https://www.epam.com/how-we-do-it";

        private const string OurWorkPage = "https://www.epam.com/our-work";

        [SetUp]
        public void Setup()
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Window.Maximize();
        }

        [Test]
        public void OpenMainPageTest()
        {
            // Act
            _chrome.Navigate().GoToUrl(MainPage);

            // Assert
            Assert.That(_chrome.Url, Is.EqualTo(MainPage));
        }

        [Test]
        public void HowWeDoItPageIsOpenedTest()
        {
            // Act
            _chrome.Navigate().GoToUrl(HowWeDoItPage);
            _chrome.Navigate().GoToUrl(OurWorkPage);
            _chrome.Navigate().Refresh();
            _chrome.Navigate().Back();

            // Assert
            Assert.That(_chrome.Url, Is.EqualTo(HowWeDoItPage));
        }

        [TearDown]
        public void TearDown()
        {
            _chrome.Quit();
        }
    }
}