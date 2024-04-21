using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Pages
{
    public class AlnokPage
    {
        private readonly IWebDriver driver;

        public AlnokPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement alnok => driver.FindElement(By.XPath("//a[@class=\"btn btn-primary btn-lg\"]"));
        IWebElement Image1 => driver.FindElement(By.XPath("//div[@id='product-wrap']/article/section//img[@alt='Alnok']"));

        public void alnokKurv()
        {
            alnok.Click();
        }
    }
}
