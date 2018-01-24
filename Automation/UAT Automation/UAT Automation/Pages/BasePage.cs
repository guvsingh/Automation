using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using UAT_Automation.WebDriver;

namespace UAT_Automation.Pages
{
    public class BasePage
    {
        private readonly WebDriverManager _webDriverManager;

        public BasePage(WebDriverManager webDriverManager)
        {
            PageFactory.InitElements(webDriverManager.WebDriver, this);
            _webDriverManager = webDriverManager;
        }

        public IWebElement PageName => _webDriverManager.Wait.Until(ExpectedConditions.ElementIsVisible(By.TagName("h1")));
    }
}
