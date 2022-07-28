
using OpenQA.Selenium;

namespace Unacademy
{
    public class StartlearningPage : UtilityClass
    {
        private IWebDriver driver;
        private By StartlearningButton = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
       

        public StartlearningPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartLearningButton()
        {
            driver.FindElement(StartlearningButton).Click();

        }
       
                       
    }
}
