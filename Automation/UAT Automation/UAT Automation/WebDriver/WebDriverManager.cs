using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UAT_Automation.WebDriver
{
    public class WebDriverManager
    {
        public IWebDriver WebDriver { get; set; }

        public WebDriverWait Wait { get; set; }

        public string ScreenShotFileName { get; set; }

        public void Teardown()
        {
            WebDriver.Quit();
            WebDriver = null;
        }
    }
}
