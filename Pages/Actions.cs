using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_PON.Pages
{
    class Actions : login
    {
        IWebDriver driver;

        public Actions(IWebDriver driver) : base(driver)
        {
            driver = driver;
        }
        public void username1()
        {
            username.SendKeys("ariqt1");
        }
        public void password1()
        {
            password.SendKeys("Ariqt@123");
        }
        public void keepmesign()
        {
            Keepmesignin.Click();
        }
        public void Login1()
        {
            sighnin.Click();
        }
    }
}
