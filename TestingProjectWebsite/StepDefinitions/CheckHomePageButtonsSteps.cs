using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestingProjectWebsite.PageObjectsModel;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public sealed class CheckHomePageButtonsSteps:Hooks
    {
        [Given(@"I navigate to the HomePage buttons")]
        public void GivenINavigateToTheHomePageButtons()
        {
           HomePage homePage = new HomePage(Driver);
           homePage.signInButton.Click();
           homePage.homeButton.Click();
        }
        
        [Given(@"I click all buttons")]
        public void GivenIClickAllButtons()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.VerifyNextPrevButtons();
            homePage.VerifyPopularBestSellersButtons();
           
        }
        
        [Then(@"I see everything each button does")]
        public void ThenISeeEverythingEachButtonDoes()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='home-page-tabs']/li[1]/a")).Displayed);
        }
    }
}
