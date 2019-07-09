using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using SpecflowTests.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class LanguageFeatureSteps :Utils.Start
    {
        
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Start startpage = new Start();
            //startpage.SetUp();
            //Wait
            Thread.Sleep(1500);
       
            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
            Thread.Sleep(10000);
            
        }
        
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                int rows = Driver.driver.FindElements(By.XPath("//table[@id='account-profile-section']/tbody/tr")).Count;

                for (int i = 1; i <= rows; i++)
                {
                    string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    { 

                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                    }

                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }

            }
            catch(Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed",e.Message);
            }

            


        }

        [When(@"I update existing language")]
        public void WhenIUpdateExistingLanguage()
        {
            IWebElement writebtn = Driver.driver.FindElement(By.XPath("//td[text()='English' ]/following-sibling::td[text()='Basic']/following-sibling::td[@class='right aligned']/child::span[@class='button']/child::i[@class='outline write icon']"));
            writebtn.Click();
            IWebElement editlangtext = Driver.driver.FindElement(By.XPath("//input[@value='English']"));
            editlangtext.Clear();
            editlangtext.SendKeys("Thai");
            IWebElement editleveldropdown = Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            editleveldropdown.Click();
            IWebElement fluentlevel = Driver.driver.FindElement(By.XPath("//*[contains(@value,'Fluent')]"));
            fluentlevel.Click();
            IWebElement updatebtn = Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
            updatebtn.Click();
            Thread.Sleep(10000);
        }

        [Then(@"that language should be updated on my listings")]
        public void ThenThatLanguageShouldBeUpdatedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "Thai";
                int rows = Driver.driver.FindElements(By.XPath("//table[@id='account-profile-section']/tbody/tr")).Count;

                for (int i = 1; i <= rows; i++)
                {
                    string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    {

                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language Updated Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageUpdated");
                    }

                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }

        [When(@"I delete existing language")]
        public void WhenIDeleteExistingLanguage()
        {
            IWebElement removebtn = Driver.driver.FindElement(By.XPath("//td[text()='Thai']/following-sibling::td[text()='Fluent']/following-sibling::td/child::span/child::i[@class='remove icon']"));
            removebtn.Click();
        }

        [Then(@"that language should be deleted from my listings")]
        public void ThenThatLanguageShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                Thread.Sleep(1000);
                Boolean ActualValue = Driver.driver.FindElements(By.XPath("//td[text()='Thai']")).Count > 0;
                Thread.Sleep(500);
                if (ActualValue == false)
                {

                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language Deleted Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");


            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }

    }



}
