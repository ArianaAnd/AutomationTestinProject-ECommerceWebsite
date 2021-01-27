using System;
using TestingProjectWebsite.PageObjectsModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingProjectWebsite.StepDefinitions
{
    [Binding]
    public class SignInWithExistingUserSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public SignInWithExistingUserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I click the signIn button")]
        public void GivenIClickTheSignInButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authentification();
        }
        
        [When(@"I login with the following credentials")]
        public void WhenILoginWithTheFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            SignInPage loginPage = new SignInPage(Driver);
            loginPage.EnterCredentials(user);
        }
        
        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a")).Displayed);
        }
    }
}
