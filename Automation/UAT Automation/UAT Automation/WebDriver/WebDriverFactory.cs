using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UAT_Automation.WebDriver
{
    public class WebDriverFactory
    {
        private static WebDriverManager _webDriverManager;

        public static WebDriverManager Get()
        {
            _webDriverManager = new WebDriverManager();
         
            ConfigureWebDriver();
            ConfigureWebDriverWait();

            return _webDriverManager;
        }

        private static void ConfigureWebDriver()
        {
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("--lang=en-GB");
            chromeOptions.AddArgument("no-sandbox");
            chromeOptions.AddArguments("--disable-popup-blocking");

            var chromeDriverService = ChromeDriverService.CreateDefaultService();

            _webDriverManager.WebDriver = new ChromeDriver(chromeDriverService, chromeOptions, new TimeSpan(0,0,0,180));

            _webDriverManager.WebDriver.Manage().Window.Maximize();
        }

        private static void ConfigureWebDriverWait()
        {
            var timespanInSeconds = new TimeSpan(0, 0, 0, 15);
            _webDriverManager.Wait = new WebDriverWait(_webDriverManager.WebDriver, timespanInSeconds);
        }
    }
}
