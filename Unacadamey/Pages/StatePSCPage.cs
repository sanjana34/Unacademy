
using OpenQA.Selenium;

namespace Unacademy
{
    public class StatePSCPage : UtilityClass
    {
        private IWebDriver driver;
        private By StartlearningButton = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
        private By State_PSC = By.XPath("//*[@id='TNXLS']/p");
        private By TNPSC = By.XPath("//*[@id='TNXLS']/div/div[5]/div[2]/p[1]/span");



        public StatePSCPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartLearningButton()
        {
            driver.FindElement(StartlearningButton).Click();


        }
        public void Tnpsc()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement State_PSC = driver.FindElement(By.XPath("//*[@id='TNXLS']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", State_PSC);
            driver.FindElement(TNPSC).Click();



        }
    }
}
