using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class DressesPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public DressesPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }
        public void AddDresseToCart()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 1000)");

            Actions builder = new Actions(_driver);
            builder.MoveToElement(printedDressElement).Perform();
            printedDressButton.Click();
            Thread.Sleep(2000);
            continueShoppingButton.Click();
            builder.MoveToElement(pricePritedDressElement).Perform();
            pricyPritedDressButton.Click();
            Thread.Sleep(2000);
            continueShoppingButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 1350)");
            //builder.MoveToElement(summerPritedDressElement).Perform();
            Thread.Sleep(1000);
            summerPritedDressButton.Click();
        }
        public void AddDressToWishList()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");

            addToWishListButton.Click();
            // _driver.SwitchTo().Frame(0);
            Thread.Sleep(1100);
            Assert.IsTrue(addedToWishListText.Text == "Added to your wishlist.");
            addedToWishListBannerCloseButton.Click();
        }
    }
}
