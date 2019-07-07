using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Skillswap
{
    [Binding]
    public class LanguagesFeatureSteps
    {
        IWebDriver driver;
        [Given(@"I have log in and in my Profile page and clicked on languages tab")]
        public void GivenIHaveLogInAndInMyProfilePageAndClickedOnLanguagesTab()
        {
            driver = new ChromeDriver();
            LoginPage loginpage = new LoginPage(driver);
            loginpage.LoginSuccess();
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ClickProfile();
            profilepage.ClickLanguages();
        }
        
        [Given(@"I have entered language which is not duplicate and level and press add button")]
        public void GivenIHaveEnteredLanguageWhichIsNotDuplicateAndLevelAndPressAddButton()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.AddNewLanguage();
        }
        
        
        [Then(@"I should be able to add language to my profile")]
        public void ThenIShouldBeAbleToAddLanguageToMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheLanguageAdded();
        }

        [Given(@"clicked on the write button of the language to be edited and update the details")]
        public void GivenClickedOnTheWriteButtonOfTheLanguageToBeEditedAndUpdateTheDetails()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.EditTheExistingLanguage();
        }

        [Then(@"I should be able to update the language in my profile")]
        public void ThenIShouldBeAbleToUpdateTheLanguageInMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheLanguageEdited();
        }

        [Given(@"clicked on the remove button of the language to be deleted")]
        public void GivenClickedOnTheRemoveButtonOfTheLanguageToBeDeleted()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.DeleteTheExistingLanguage();
        }

        [Then(@"I should be able to delete the language from my profile")]
        public void ThenIShouldBeAbleToDeleteTheLanguageFromMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheLanguageDeletion();
        }



    }
}
