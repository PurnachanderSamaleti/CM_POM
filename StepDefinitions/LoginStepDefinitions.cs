using CM_PON.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CM_PON.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver;
        [Obsolete]
        public LoginStepDefinitions()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("CurrentDriver");
        }

        [Given(@"enter a valid username")]
        public void GivenEnterAValidUsername()
        {
            driver.Navigate().GoToUrl("https://sensor-mfe.dev-cowmanager.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions AC = new Actions(driver);
            AC.username1();
        }

        [When(@"enter a valid password")]
        public void WhenEnterAValidPassword()
        {
            throw new PendingStepException();
        }

        [When(@"Click on keep me sign in button")]
        public void WhenClickOnKeepMeSignInButton()
        {
            throw new PendingStepException();
        }

        [Then(@"click on sign in button")]
        public void ThenClickOnSignInButton()
        {
            throw new PendingStepException();
        }
    }
}
