using OpenQA.Selenium.Support.PageObjects;
using UAT_Automation.WebDriver;

namespace UAT_Automation.Pages
{
    public class WorkPage : BasePage
    {
        private readonly WebDriverManager _webDriverManager;

        public WorkPage(WebDriverManager webDriverManager) : base(webDriverManager)
        {
            PageFactory.InitElements(webDriverManager.WebDriver, this);
            _webDriverManager = webDriverManager;
        }
    }
}
