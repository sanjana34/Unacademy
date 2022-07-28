
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinitions
{
    [Binding]
    public class StartlearningStepDefinitions : ApplicationHooks
    {        
        [Given(@"Chrome is launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Thread.Sleep(5000);
        }

        [When(@"User clicks on Startlearning Button")]
        public void WhenUserClicksOnStartlearningButton()
        {
            Thread.Sleep(5000);
             slp.StartLearningButton();
        }

        [Then(@"It shows Home Page")]
        public void ThenItShowsHomePage()
        {
            Thread.Sleep(5000);
            CaptureScreenshot();
        }
        [When(@"User goto JEEandNEETPreparation and clicks on IIT JEE")]
        public void WhenUserGotoJEEandNEETPreparationAndClicksOnIITJEE()
        {

            jnp.IITjEE();
            Thread.Sleep(5000);

        }

        [Then(@"It shows IIT JEE page with get subscription button")]
        public void ThenItShowsIITJEEPageWithGetSubscriptionButton()
        {

            Thread.Sleep(5000);
            CaptureScreenshot();
        }
        [When(@"User goto HealthandFitness and clicks on Yoga")]
        public void WhenUserGotoHealthandFitnessAndClicksOnYoga()
        {
            hfp.yoga();
            Thread.Sleep(5000);
            //hfp.yoga();

        }

        [Then(@"It shows Yoga page with Choose a batch button")]
        public void ThenItShowsYogaPageWithChooseABatchButton()
        {
            Thread.Sleep(5000);
            CaptureScreenshot();
            Thread.Sleep(5000);
        }
        [When(@"User goto Marketing and clicks on Digital Marketing")]
        public void WhenUserGotoMarketingAndClicksOnDigitalMarketing()
        {
            mp.digitalMarketing();
            Thread.Sleep(5000);

        }

        [Then(@"It shows Digital Marketing page with Choose a batch button")]
        public void ThenItShowsDigitalMarketingPageWithChooseABatchButton()
        {
            Thread.Sleep(5000);
            CaptureScreenshot();
            Thread.Sleep(5000);
        }
        [When(@"User goto StatePSC and clicks on TNPSC")]
        public void WhenUserGotoStatePSCAndClicksOnTNPSC()
        {
            Thread.Sleep(2000);
            sp.Tnpsc();
            Thread.Sleep(5000);
        }

        [Then(@"It shows TNPSC page with Get a subscription button")]
        public void ThenItShowsTNPSCPageWithGetASubscriptionButton()
        {
            Thread.Sleep(5000);
            CaptureScreenshot();
        }
    }
}
