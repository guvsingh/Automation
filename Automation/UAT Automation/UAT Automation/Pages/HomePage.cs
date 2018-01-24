using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using UAT_Automation.WebDriver;

namespace UAT_Automation.Pages
{
    public class HomePage
    {
        private readonly WebDriverManager _webDriverManager;

        public HomePage(WebDriverManager webDriverManager)
        {
            PageFactory.InitElements(webDriverManager.WebDriver, this);
            _webDriverManager = webDriverManager;
        }

        public IWebElement LatestNewsSection
        {
            get
            {
                var webElement = _webDriverManager.Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("news-post__listing")));

                new Actions(_webDriverManager.WebDriver)
                    .MoveToElement(webElement)
                    .Perform();

                return webElement;
            } 
        }
        
        public IWebElement AboutMenu => _webDriverManager.Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[1]/a")));

        public IWebElement ServiceMenu => _webDriverManager.Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[3]/a")));

        public IWebElement WorkMenu => _webDriverManager.Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[2]/a")));
    }
}
