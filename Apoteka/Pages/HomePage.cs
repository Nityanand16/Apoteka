using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Login Button
        IWebElement LogIn => driver.FindElement(By.ClassName("menulist-icon"));
        IWebElement LinkLogind => driver.FindElement(By.LinkText("Log ind"));

        
        public bool IsHomePage()
        {
            return LinkLogind.Displayed;
        }
        
        public void ClickLogin()
        {
            LogIn.Click();
        }
    }
}
