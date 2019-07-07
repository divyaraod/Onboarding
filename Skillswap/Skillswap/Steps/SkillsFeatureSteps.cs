using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Skillswap
{
    [Binding]
    public class SkillsFeatureSteps
    {
        IWebDriver driver;
        [Given(@"I have log in and in my Profile page and clicked on skills tab")]
        public void GivenIHaveLogInAndInMyProfilePageAndClickedOnSkillsTab()
        {
            driver = new ChromeDriver();
            LoginPage loginpage = new LoginPage(driver);
            loginpage.LoginSuccess();
            ProfilePage profilepage = new ProfilePage(driver);
            // profilepage.ClickProfile();
            profilepage.ClickSkills();
        }

        [Given(@"I have entered (.*) which is not duplicate and level and press add button")]
        public void GivenIHaveEnteredSkillWhichIsNotDuplicateAndLevelAndPressAddButton(string s)
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.AddNewSkill(s);

        }

        [Then(@"I should be able to add skill to my profile")]
        public void ThenIShouldBeAbleToAddSkillToMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheSkillAdded();
        }

        [Given(@"clicked on the write button of the skill to be edited and update the details")]
        public void GivenClickedOnTheWriteButtonOfTheSkillToBeEditedAndUpdateTheDetails()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.EditTheExistingSkill();
        }

        [Then(@"I should be able to update the skill in my profile")]
        public void ThenIShouldBeAbleToUpdateTheSkillInMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheSkillEdited();
        }

        [Given(@"clicked on the remove button of the Skill to be deleted")]
        public void GivenClickedOnTheRemoveButtonOfTheSkillToBeDeleted()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.DeleteTheExistingSkill();
        }

        [Then(@"I should be able to delete the skill from my profile")]
        public void ThenIShouldBeAbleToDeleteTheSkillFromMyProfile()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ValidateTheSkillDeletion();
        }
    }
}
