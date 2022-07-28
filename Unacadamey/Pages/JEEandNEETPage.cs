
  using OpenQA.Selenium;

namespace Unacademy
{
    public class JEEandNEETPage : UtilityClass
    {
        private IWebDriver driver;
        private By StartlearningButton = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
        private By JEE_and_NEET_Preparation = By.XPath("//*[@id='MIBRP']/p");
        private By IIT_JEE = By.XPath("//*[@id='MIBRP']/div/div[1]/div[2]/p[1]");


       
        public JEEandNEETPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartLearningButton()
        {
            driver.FindElement(StartlearningButton).Click();
            

        }
        public  void IITjEE()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement JEE_and_NEET_Preparation = driver.FindElement(By.XPath("//*[@id='MIBRP']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", JEE_and_NEET_Preparation);
           // IWebElement IIT_JEE = driver.FindElement(By.XPath("//*[@id='MIBRP']/div/div[1]/div[2]/p[1]"));
            driver.FindElement(IIT_JEE).Click();
            


        }
    }
}

