using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProjectWebsite.PageObjectsModel
{
    partial class WomenPage
    {
        public IWebElement printedSummerDressButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[1]/div/a[1]/img"));

        public IWebElement printedSummerDressAddtoCartButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/div[2]/a[1]"));

        public IWebElement printedSummerDressMoreButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/div[2]/a[2]"));

        public IWebElement printedSummerDressBlackColorButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/div[3]/ul/li[1]/a"));

        public IWebElement printedSummerInStockButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/span"));
        public IWebElement printedSummerPriceButton =>
            _driver.FindElement(
                By.XPath("/html/body/div[2]/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/div[1]/span[1]"));

    }
}
