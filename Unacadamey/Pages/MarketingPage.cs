
using OpenQA.Selenium;

namespace Unacademy
{
    public class MarketingPage : UtilityClass
    {
        private IWebDriver driver;
        private By StartlearningButton = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
        private By Marketing = By.XPath("//*[@id='RNLDU']/p");
        private By Digital_Marketing = By.XPath("//*[@id='RNLDU']/div/div[1]/div[2]/p[1]/span");



        public MarketingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartLearningButton()
        {
            driver.FindElement(StartlearningButton).Click();


        }
        public void digitalMarketing()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement Marketing = driver.FindElement(By.XPath("//*[@id='RNLDU']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", Marketing);
           driver.FindElement(Digital_Marketing).Click();



        }
    }
}
