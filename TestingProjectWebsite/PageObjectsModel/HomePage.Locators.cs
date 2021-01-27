using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProjectWebsite.PageObjectsModel
{
   partial class HomePage
    {
        //Header
        private IWebElement contactUsHomePageButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/header/div[2]/div/div/nav/div[2]/a"));
        private IWebElement signInHomePageButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        public IWebElement createAccountButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
        public IWebElement signInButton => _driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a"));

        //Home Icon
        public IWebElement homeButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/a[1]"));

        //Products
        public IWebElement fadedshortSleeveShirtButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]/img"));
        private IWebElement fadedshortSleeveShirtAddToCartButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[1]"));
        public IWebElement blouseButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[2]/div/div[1]/div/a[1]/img"));
        public IWebElement blouseAddToCartButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div/div[1]/ul[1]/li[2]/div/div[2]/div[2]/a[1]"));


        //Checkout
        public IWebElement proceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a"));
        public IWebElement emailAddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input"));

        //Search
        public IWebElement searchTextBox => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/input[4]"));
        public IWebElement searchButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/button"));

        //Women/Dresses/T-Shirts Products Buttons
        public IWebElement womenButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/header/div[3]/div/div/div[6]/ul/li[1]/a"));
        public IWebElement dressButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[2]/a"));
        public IWebElement tShirtButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a"));



        //carousel claims
        private IWebElement nextCarouselButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[1]/div/div[2]/div/a[2]"));
        public IWebElement prevCarouselButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[1]/div/div[2]/div/a[1]"));

        //Popular/Best Sellers Buttons
        private IWebElement popularButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div/ul/li[1]/a"));
        public IWebElement bestSellerButton => _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div/ul/li[1]/a"));

    }
}
