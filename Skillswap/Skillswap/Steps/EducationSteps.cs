using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Skillswap
{
    [Binding]
    public class EducationSteps
    {
        IWebDriver driver;
        [Given(@"I have log in and in my Profile page and clicked on Education tab")]
        public void GivenIHaveLogInAndInMyProfilePageAndClickedOnEducationTab()
        {
            driver = new ChromeDriver();
            LoginPage loginpage = new LoginPage(driver);
            loginpage.LoginSuccess();
            ProfilePage profilepage = new ProfilePage(driver);
          //  profilepage.ClickProfile();
            profilepage.ClickEducation();
        }

        [Given(@"I have entered Education data like year country title (.*) and (.*) and press add button")]
        public void GivenIHaveEnteredEducationDataLikeYearCountryTitleUniversityAndDegreeAndPressAddButton(string uni, string deg)
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.AddNewEducation(uni,deg);
        }


        [Then(@"I should be able to add new Education entry to my profile")]
        public void ThenIShouldBeAbleToAddNewEducationEntryToMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheEducationAdded();
        }

        [Given(@"I have edited Education details and press update button")]
        public void GivenIHaveEditedEducationDetailsAndPressUpdateButton()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.EditTheExistingEducation();
        }

        [Then(@"I should be able to edit Education details to my profile")]
        public void ThenIShouldBeAbleToEditEducationDetailsToMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheEducationEdited();
        }

        [Given(@"I have pressed remove icon of the education entry which needs to be deleted")]
        public void GivenIHavePressedRemoveIconOfTheEducationEntryWhichNeedsToBeDeleted()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.DeleteTheExistingEducation();
        }

        [Then(@"I should be able to delete Education entry in my profile")]
        public void ThenIShouldBeAbleToDeleteEducationEntryInMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheEducationDeletion();
        }




    }
}
