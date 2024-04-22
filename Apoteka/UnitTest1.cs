using Apoteka.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace Apoteka
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testfile()
        {

            // Create a new instance of Selenium Web Driver
            var driver = new ChromeDriver();
            
            // Navigate to the url
            driver.Navigate().GoToUrl("https://apopro.dk/");
            
            // Maximize the browser window
            driver.Manage().Window.Maximize();
            
            //Accepted the Cookies
            IWebElement webElement = driver.FindElement(By.ClassName("coi-banner__accept"));
            webElement.Click();
            
            //Assertions
            HomePage homePage = new HomePage(driver);
            var getHomePage = homePage.IsHomePage();
            Assert.IsTrue(getHomePage);
            Console.WriteLine("User navigate to HomePage");

            //Click on log ind button
            homePage.ClickLogin();

            //User login with wrong email
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("nityanandgupt@yahoo.com", "Password1243");
            
            //Assert "User failed to logged in"
            loginPage.IsProfilePage();

            //User login with wrong password
            loginPage.UserFields();
            loginPage.Login("nityanandgupta@yahoo.com", "Password124");
            
            //Assert "User failed to logged in"
            loginPage.IsProfilePage();

            //User login with corect credentials
            loginPage.UserFields();
            loginPage.Login("nityanandgupta@yahoo.com", "Password1243");
            
            //Assert "User logged in successfully"
            loginPage.IsProfilePage();

            //Click on Se Allergi Medicin
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.MouseHoverHåndkøb();
            profilePage.SeAllergiMedicin();

            //Click on Alnok Medicine
            AllergiMedicinPage allergiMedicinPage = new AllergiMedicinPage(driver);
            allergiMedicinPage.alnokMedicin();

            //Click on basket from alnok page
            AlnokPage alnokPage = new AlnokPage(driver);
            alnokPage.alnokKurv();

            //Click on alnok kurv button popup
            AlnokPopup alpopUp = new AlnokPopup(driver);
            alpopUp.alnokPopup();

            //Compare product
            CartPage cartPage = new CartPage(driver);
            //cartPage.compareProduct();

            //Assert item in the basket at cart page
            cartPage.itemInBasketConfirmation();

            //Click on delete button and empty the cart
            cartPage.deleteOrder();

            //Assert basket is empty at cart page
            cartPage.EmptyBasketConfirmation();
        }
    }
}
