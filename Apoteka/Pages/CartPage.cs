using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Apoteka.Pages
{
    public class CartPage
    {
        private readonly IWebDriver driver;

        public CartPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        IWebElement TotalPrice => driver.FindElement(By.XPath("//div[@class=\"price h3 mn ng-binding\"]"));
        IWebElement DeleteOrder => driver.FindElement(By.XPath("//a[@class=\"remove-btn lh24 ml30\"]"));
        IWebElement PriceDeleted => driver.FindElement(By.XPath("//div[@class=\"cart_empty\"]"));
        IWebElement alnokPopupPageText => driver.FindElement(By.XPath("/html//div[@id='addToCart']/div[@role='document']/div[@class='modal-content']/div[@class='modal-body']//img[@alt='Alnok']"));
        IWebElement cartPageText => driver.FindElement(By.XPath("//div[@id='order']//div[@class='row']/div[@class='col-md-7']/div/div[@class='col-xs-12 ng-scope']//div[@cl ass='space-between']/a[@href='/alnok-10-mg-100-stk-filmovertrukne-tabletter-170273']//img"));
        IWebElement emptyKurv => driver.FindElement(By.XPath("//div[@class='cart_empty']//h3"));
        IWebElement itemInBasket => driver.FindElement(By.XPath("//div[@class=\"add-item btn-group mn pn\"]"));
        
        public void itemInBasketConfirmation()
        { 
            if (itemInBasket.Displayed)
            {
                Console.WriteLine("Item added to basket: Verification passed.");
            }
            else
            {
                Console.WriteLine("Item added to basket: Verification failed.");
            }
        }
        
        public void deleteOrder()
        {
            DeleteOrder.Click();
        }

        public void EmptyBasketConfirmation()
        {
            if (itemInBasket.Displayed)
            {
                Console.WriteLine("Basket empty: Verification passed.");
            }
            else
            {
                Console.WriteLine("Basket not empty: Verification failed.");
            }
        }
     }   
    
}