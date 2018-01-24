using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UAT_Automation.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly SiteNavigation _siteNavigation;

        public HomePageSteps()
        {
            _siteNavigation = new SiteNavigation(Hooks.WebDriverManager);
        }

        [Given(@"I am on the valtech homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _siteNavigation.GoToHomePage();
        }

        [Then(@"the latest news page is displayed on the HomePage")]
        public void ThenTheLatestNewsPageIsDisplayedOnTheHomePage()
        {
            var isDisplayed = _siteNavigation.HomePage.LatestNewsSection.Displayed;

            Assert.True(isDisplayed);
        }

        [Given(@"I am on the (.*) page")]
        public void GivenIAmOnTheAbout(string menupage)
        {
            switch (menupage)
            {
                case "About":
                    _siteNavigation.GoToHomePage().HomePage.AboutMenu.Click();
                    break;
                case "Services":
                    _siteNavigation.GoToHomePage().HomePage.ServiceMenu.Click();
                    break;
                case "Work":
                    _siteNavigation.GoToHomePage().HomePage.WorkMenu.Click();
                    break;
            }
            
        }

        [Then(@"the (.*) page is displayed")]
        public void ThenTheAboutPageIsDisplayed(string pagename)
        {
            switch (pagename)
            {
                case "About":
                    Assert.AreEqual("About", _siteNavigation.AboutPage.PageName.Text);
                    break;
                case "Services":
                    Assert.AreEqual("Services", _siteNavigation.ServicesPage.PageName.Text);
                    break;
                case "Work":
                    Assert.AreEqual("Work", _siteNavigation.WorkPage.PageName.Text);
                    break;
            }
        }

    }
}
