using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Pages
{
    public class AllergiMedicinPage
    {
        private readonly IWebDriver driver;

        public AllergiMedicinPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement AlnokMedicin => driver.FindElement(By.XPath("//body[@id='commonController']/div[2]/main//article/div[1]/div[1]/section/div[@class='multi-columns-row']/section[1]/div/div[1]/a[@href='/alnok-10-mg-100-stk-filmovertrukne-tabletter-170273']//h3[@class='thumbnail-product-name']"));

        public void alnokMedicin()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 40)");
            AlnokMedicin.Click();
        }
    }
}

