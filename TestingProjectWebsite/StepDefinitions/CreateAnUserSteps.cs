using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestingProjectWebsite.PageObjectsModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class CreateAnUserSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public CreateAnUserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I navigate to website and click login")]
        public void GivenINavigateToWebsiteAndClickLogin()
        {
           HomePage homePage = new HomePage(Driver);
           homePage.Authentification();
        }
        [Then(@"I fill desired email")]
        public void ThenIFillDesiredEmail(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
            homePage.signInButton.Click();
            System.Threading.Thread.Sleep(2000);
        }


    
        [When(@"I fill the register form with following data")]
        public void WhenIFillTheRegisterFormWithFollowingData(Table table)
        {
            System.Threading.Thread.Sleep(2000);
            var user = table.CreateInstance<UserDto>();
            CreateAccountPage createAccountPage = new CreateAccountPage(Driver);
            createAccountPage.EnterCreateAccountCredentials(user);
        }

        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            CreateAccountPage createAccountPage = new CreateAccountPage(Driver);
            createAccountPage.registerButton.Click();
        }
        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a")).Displayed);
        }
    }
}
