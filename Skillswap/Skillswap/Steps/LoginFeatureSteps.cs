using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Skillswap
{
    [Binding]
    public class LoginFeatureSteps
    {
        IWebDriver driver;
        [Given(@"I am in the Home Page")]
        public void GivenIAmInTheHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.skillswap.pro");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have navigated to Login Page")]
        public void GivenIHaveNavigatedToLoginPage()
        {
            //Clicking on Signin button
           driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();
 
        }

        [When(@"I enter valid data")]
        public void WhenIEnterValidData()
        {
            //Entering email and password details
            IWebElement email =  driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            email.SendKeys("divyarao.devaraneni@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.SendKeys("123123");


        }

        [When(@"click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            //Clicking on Login button
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            Thread.Sleep(10000);
        }
        
        [Then(@"I should be able to login successfully")]
        public void ThenIShouldBeAbleToLoginSuccessfully()
        {
         
            IWebElement hidivya = driver.FindElement(By.XPath("//span[contains(.,'Divya')]"));
            Assert.That(hidivya.Text, Does.EndWith("Divya"));

        }

        [When(@"I enter invalid data")]
        public void WhenIEnterInvalidData()
        {
            //Entering email and password details
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            email.SendKeys("divyarao.devaraneni@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.SendKeys("12312345");
        }

        [Then(@"I should not be able to login")]
        public void ThenIShouldNotBeAbleToLogin()
        {
            
        }



    }
}
