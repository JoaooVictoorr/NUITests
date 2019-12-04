using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace UITests
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    public class Hooks : BaseClass
    {
        private readonly BrowserType browserType;
        private int defaultTimeout = 30;

        public Hooks(BrowserType browser)
        {
            browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {

            ChooseDriverInstance(browserType);
        }

        [TearDown]
        public void TestCleanup()
        {
            Driver.Quit();
            Driver.Dispose();
        }

        private void ChooseDriverInstance(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    ChromeOptions optionsChrome = new ChromeOptions { AcceptInsecureCertificates = true };
                    Driver = new ChromeDriver(optionsChrome);
                    SetUpBrowser();
                    break;
                case BrowserType.Firefox:
                    FirefoxOptions optionsFirefox = new FirefoxOptions { AcceptInsecureCertificates = true };
                    Driver = new FirefoxDriver(optionsFirefox);
                    SetUpBrowser();
                    break;
            }
        }

        private void SetUpBrowser()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(defaultTimeout);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Navigate().GoToUrl("https://www.relevolab.com");
        }
    }
}
