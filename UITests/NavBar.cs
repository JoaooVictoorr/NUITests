using OpenQA.Selenium;
using System;

namespace UITests
{
    class NavBar : BaseClass
    {
        private string xpath_GoToMenu = "//div[@class='nav-bar']/a[text()='{0}']";

        public NavBar GoTo(string menu)
        {
            string xpath = String.Format(xpath_GoToMenu, menu);
            Driver.FindElement(By.XPath(xpath)).Click();
            return this;
        }
    }
}
