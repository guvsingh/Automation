using UAT_Automation.Pages;
using UAT_Automation.WebDriver;

namespace UAT_Automation
{
    public class SiteNavigation
    {
        private static WebDriverManager _webDriverManager;
        public readonly HomePage HomePage;
        public readonly AboutPage AboutPage;
        public readonly ServicesPage ServicesPage;
        public readonly WorkPage WorkPage;

        public WebDriverManager WebDriverManager => _webDriverManager;

        public SiteNavigation(WebDriverManager webDriverManager)
        {
            _webDriverManager = webDriverManager;

            HomePage = new HomePage(_webDriverManager);
            AboutPage = new AboutPage(_webDriverManager);
            ServicesPage = new ServicesPage(_webDriverManager);
            WorkPage = new WorkPage(_webDriverManager);
        }

        public SiteNavigation GoToHomePage()
        {
            WebDriverManager.WebDriver.Navigate().GoToUrl("https://www.valtech.com");

            return this;
        }
    }
}
