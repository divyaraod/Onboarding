using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Skillswap
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
          
        }
       
        IWebElement signinbtn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement email => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        IWebElement loginbtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        IWebElement hidivya => driver.FindElement(By.XPath("//span[contains(.,'Divya')]"));
        
        internal void LoginSuccess()
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro");
            driver.Manage().Window.Maximize();
            signinbtn.Click();
            email.SendKeys("divyarao.devaraneni@gmail.com");
            password.SendKeys("123123");
            loginbtn.Click();
            Thread.Sleep(10000);
            Assert.That(hidivya.Text, Does.EndWith("Divya")) ;

        }
        internal void LoginFailure()
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro");
            driver.Manage().Window.Maximize();
            signinbtn.Click();
            email.SendKeys("divyarao.devaraneni@gmail.com");
            password.SendKeys("1231");
            loginbtn.Click();
        }
    }
}