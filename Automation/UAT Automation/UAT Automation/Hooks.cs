using TechTalk.SpecFlow;
using UAT_Automation.WebDriver;

namespace UAT_Automation
{
    [Binding]
    public sealed class Hooks
    {
        private static SiteNavigation _siteNavigation;
        private static WebDriverManager _webDriverManager;

        public static WebDriverManager WebDriverManager
        {
            get
            {
                if (_webDriverManager?.WebDriver == null)
                {
                    _webDriverManager = WebDriverFactory.Get();
                }

                return _webDriverManager;
            }
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _siteNavigation = new SiteNavigation(WebDriverManager);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebDriverManager.Teardown();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
