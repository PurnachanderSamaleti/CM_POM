using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_PON.Pages
{
    class login
    {
        IWebDriver driver;
        public login(IWebDriver driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "Username / E-Mail")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "rememberMe")]
        public IWebElement Keepmesignin { get; set; }
        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement sighnin { get; set; }
    }
}
