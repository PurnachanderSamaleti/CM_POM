using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CM_PON.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver driver;
        [BeforeScenario]
        public void BeforeLogin()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));
            ScenarioContext.Current.Add("CurrentDriver", driver);
        }
        

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}