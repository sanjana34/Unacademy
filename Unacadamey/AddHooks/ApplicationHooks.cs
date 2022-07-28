using TechTalk.SpecFlow;

namespace Unacademy
{
    public class ApplicationHooks : UtilityClass
    {


          public StartlearningPage slp;  
          public JEEandNEETPage jnp;
          public MarketingPage mp;
          public StatePSCPage sp;
          public HealthandFitnessPage hfp;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            LaunchApp(url);

             slp = new StartlearningPage(driver);
             jnp = new JEEandNEETPage(driver);
             mp = new MarketingPage(driver);
             sp = new StatePSCPage(driver);
             hfp = new HealthandFitnessPage(driver);

            Thread.Sleep(5000);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
