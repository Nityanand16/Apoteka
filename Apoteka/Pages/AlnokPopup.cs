using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Pages
{
    public class AlnokPopup
    {
        private readonly IWebDriver driver;

        public AlnokPopup(IWebDriver driver) 
        {
            this.driver = driver;
        }

        IWebElement alnokKurvButton => driver.FindElement(By.XPath("//html//div[@id='addToCart']/div[@role='document']/div[@class='modal-content']/div[@class='modal-body']/div//a[@href='/Cart']"));

        public void alnokPopup() 
        {
            string current = driver.CurrentWindowHandle;
            Thread.Sleep(3000);
            driver.SwitchTo().Window(current);
            alnokKurvButton.Click();
            
          
        }
    }
}
