using OpenQA.Selenium.Support.PageObjects;
using UAT_Automation.WebDriver;

namespace UAT_Automation.Pages
{
    public class ServicesPage :BasePage
    {
        private readonly WebDriverManager _webDriverManager;

        public ServicesPage(WebDriverManager webDriverManager) : base(webDriverManager)
        {
            PageFactory.InitElements(webDriverManager.WebDriver, this);
            _webDriverManager = webDriverManager;
        }
    }
}
