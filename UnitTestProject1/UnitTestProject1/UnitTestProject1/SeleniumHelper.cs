using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    public class SeleniumHelper
    {
        public SeleniumHelper()
        {
            Browser = new ChromeDriver();
        }

        public static IWebDriver Browser { get; set; }
    }
}
