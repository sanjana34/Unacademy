

using OpenQA.Selenium;

namespace Unacademy
{
    public class HealthandFitnessPage : UtilityClass
    {
        private IWebDriver driver;
        private By StartlearningButton = By.XPath("//*[@id='__next']/div[2]/section/div[2]/div/div/section/div[1]/a/button");
        private By HealthandFitness = By.XPath("//*[@id='CHQJT']/p");
        private By Yoga = By.XPath("//*[@id='CHQJT']/div/div[1]/div[2]/p[1]/span");



        public HealthandFitnessPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void StartLearningButton()
        {
            driver.FindElement(StartlearningButton).Click();


        }
        public void yoga()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement HealthandFitness = driver.FindElement(By.XPath("//*[@id='CHQJT']/p"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", HealthandFitness);
            driver.FindElement(Yoga).Click();



        }
    }
}
