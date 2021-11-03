using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
    public static class SeleniumHelper
    {
        public static IWebDriver Browser { get; set; }

        public static void Click(this By by, uint timeoutSeconds = 5)
        {
            WaitForElement(by, timeoutSeconds).Click();
        }

        public static void Clear(this By by, uint timeoutSeconds = 5)
        {
            WaitForElement(by, timeoutSeconds).Clear();
        }

        public static IWebElement TryFindElement(this By by, uint timeoutSeconds = 5)
        {
            try
            {
                return WaitForElement(by, timeoutSeconds);
            }
            catch
            {
                return null;
            }
            
        }

        public static void SendKeys(this By by, string text, uint timeoutSeconds = 5)
        {
            WaitForElement(by, timeoutSeconds).SendKeys(text);
        }

        public static IWebElement WaitForElement(By by, uint timeoutSeconds)
        {
            var wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
