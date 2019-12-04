using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    public class Input : BaseClass
    {
        string xpathInput = "//input[@placeholder='{0}']";

        public void InformValue(string inputName, string value)
        {
            string xpath = string.Format(xpathInput, inputName);
            Driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }
    }
}
