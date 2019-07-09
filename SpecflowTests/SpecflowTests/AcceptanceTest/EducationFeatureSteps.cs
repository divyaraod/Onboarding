using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class EducationFeatureSteps : Utils.Start
    {
        [Given(@"I have log in and in my Profile page and clicked on Education tab")]
        public void GivenIHaveLogInAndInMyProfilePageAndClickedOnEducationTab()
        {
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
            Thread.Sleep(10000);
            //Click on Education tab
            Driver.driver.FindElement(By.XPath("//a[@class='item'][text()='Education']")).Click();
            

        }

        [Given(@"I have entered Education data like year country title (.*) and (.*) and press add button")]
        public void GivenIHaveEnteredEducationDataLikeYearCountryTitleUniversityAndDegreeAndPressAddButton(string s1, string s2)
        {
       
                //Checking for duplicate data
                Boolean isPresent = Driver.driver.FindElements(By.XPath("//td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td")).Count() > 0;
                Boolean isPresent2 = Driver.driver.FindElements(By.XPath("//td[text()='India']/following-sibling::td[text()='Kakatiya']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='CSE']/following-sibling::td")).Count() > 0;
                //Adding the Education if the information is not existed already
                if ((isPresent == false) || (isPresent2 == false))
                {
                    IWebElement addneweducationbtn = Driver.driver.FindElement(By.XPath("//th[text()='Graduation Year']/following-sibling::th[@class='right aligned']/child::div[text()='Add New']"));
                    addneweducationbtn.Click();
                    IWebElement universitytxt = Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                    universitytxt.SendKeys(s1);
                    IWebElement countrydropdownbtn = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
                    countrydropdownbtn.Click();
                    IWebElement countrybtn = Driver.driver.FindElement(By.XPath("//option[@value='India']"));
                    countrybtn.Click();
                    IWebElement titledropdownbtn = Driver.driver.FindElement(By.XPath("//select[@name='title']"));
                    titledropdownbtn.Click();
                    IWebElement titlebtn = Driver.driver.FindElement(By.XPath("//option[@value='B.Tech']"));
                    titlebtn.Click();
                    IWebElement degreetxt = Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                    degreetxt.SendKeys(s2);
                    IWebElement graduationyeardropdownbtn = Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                    graduationyeardropdownbtn.Click();
                    IWebElement graduationyearbtn = Driver.driver.FindElement(By.XPath("//option[@value='2014']"));
                    graduationyearbtn.Click();

                    //Clicking the add button to add Education
                    IWebElement addeducationbtn = driver.FindElement(By.XPath("//div[@class='fields']/child::div[@class='sixteen wide field']/child::input[@value='Add']"));
                    addeducationbtn.Click();
                    return;
                }
                // if the information already existed,cant add the education
                else
                {
                    Console.WriteLine("Cant add education since information already exists");
                }
            }
        
        [Then(@"I should be able to add new Education entry to my profile")]
        public void ThenIShouldBeAbleToAddNewEducationEntryToMyProfile()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Education");

                Thread.Sleep(1000);
                string ExpectedValue = "2014";
              //  int rows = driver.FindElements(By.XPath("//table[@id='account-profile-section']/tbody/tr")).Count;
                string ActualValue = Driver.driver.FindElement(By.XPath("//tr/child::td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                    {

                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Education Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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
