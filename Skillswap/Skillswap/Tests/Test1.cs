using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillswap
{
    
    public class Test1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            LoginPage loginpage = new LoginPage(driver);
            loginpage.LoginSuccess();

        }
        [Test]
        
        public void Languages()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ClickLanguages();
            profilepage.AddNewLanguage();
            profilepage.ValidateTheLanguageAdded();
            profilepage.EditTheExistingLanguage();
            profilepage.ValidateTheLanguageEdited();
            profilepage.DeleteTheExistingLanguage();
            profilepage.ValidateTheLanguageDeletion();

        }
        [Test]

        public void Education()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.ClickEducation();
        //    profilepage.AddNewEducation(university,degree);
         //   profilepage.ValidateTheEducationAdded();
          //  profilepage.EditTheExistingEducation();
         //   profilepage.ValidateTheEducationEdited();
          //  profilepage.DeleteTheExistingEducation();
          //  profilepage.ValidateTheEducationDeletion();

        }

    }
}
