using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apoteka.Pages
{
    public class ProfilePage
    {
        private readonly IWebDriver driver;
        private object _driver;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Profile text for assertation
        IWebElement ProfileText => driver.FindElement(By.LinkText("Profil for "));
        //Web element of Hånkøb
        IWebElement Håndkøb => driver.FindElement(By.XPath("//span[text()='Håndkøb']"));
        //Web element of AllergiMedicin
        IWebElement AllergiMedicin => driver.FindElement(By.XPath("//a[@href=\"/categories/allergi-medicin\"]"));
        
        public void MouseHoverHåndkøb ()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(Håndkøb).Perform();
        }

        public void SeAllergiMedicin ()
        {
            AllergiMedicin.Click();
        }

        

    }
}


