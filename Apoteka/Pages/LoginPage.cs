using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement EmailField => driver.FindElement(By.Id("Email"));
        IWebElement PasswordField => driver.FindElement(By.Id("password"));
        IWebElement LoginBtn => driver.FindElement(By.Id("login-submit"));
        IWebElement LinkLoginFailed => driver.FindElement(By.LinkText("Der opstod en fejl"));
        IWebElement LinkLoginPassed => driver.FindElement(By.LinkText("Profil"));

        public void Login(string Email, string password)
        {
            EmailField.SendKeys(Email);
            PasswordField.SendKeys(password);
            LoginBtn.Click();
        }
        public void UserFields()
        {
            EmailField.Clear();
            PasswordField.Clear();
        }



        public void IsProfilePage()
        {
            string currentUrl = driver.Url;
            Console.WriteLine(currentUrl);
            if (currentUrl.Contains("Profile"))
            {
                Console.WriteLine("User logged in successfully");
            }
            else
            {
                Console.WriteLine("User failed to log in");
            }

        }
            
        }
    }

