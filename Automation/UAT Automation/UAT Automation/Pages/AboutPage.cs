using OpenQA.Selenium.Support.PageObjects;
using UAT_Automation.WebDriver;

namespace UAT_Automation.Pages
{
    public class AboutPage : BasePage
    {
        private readonly WebDriverManager _webDriverManager;

        public AboutPage(WebDriverManager webDriverManager) : base(webDriverManager)
        {
            PageFactory.InitElements(webDriverManager.WebDriver, this);
            _webDriverManager = webDriverManager;
        }
    }
}
