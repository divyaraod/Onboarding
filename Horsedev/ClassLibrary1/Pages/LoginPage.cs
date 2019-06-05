using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ClassLibrary1
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement username => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//input[@value='Log in']"));
        IWebElement hellohari => driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

        internal void LoginSuccess()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            username.SendKeys("hari");
            password.SendKeys("123123");
            loginbtn.Click();
            Assert.That(hellohari.Text,Is.EqualTo("Hello hari!"));
        }

        internal void LoginFailure()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            username.SendKeys("haris");
            password.SendKeys("12312");
            loginbtn.Click();
        }
    }

    
}