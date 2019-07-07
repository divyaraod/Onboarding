using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Skillswap
{
    internal class ProfilePage
    {
        private IWebDriver driver;
        private static int rows;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickProfile()
        {
            IWebElement profilebtn = driver.FindElement(By.XPath("//a[@href='/Account/Profile']"));
            profilebtn.Click();
        }

        internal void ClickLanguages()
        {
            IWebElement langbtn = driver.FindElement(By.XPath("//a[@class='item active'][text()='Languages']"));
            langbtn.Click();
        }

        internal void AddNewLanguage()
        {
           
                    IWebElement addnewlangbtn = driver.FindElement(By.XPath("(//div[@class='ui teal button '][text()='Add New'][text()='Add New'])[1]"));
                    addnewlangbtn.Click();
                    IWebElement addlanguage = driver.FindElement(By.XPath("(//input[@placeholder='Add Language'])"));
                    addlanguage.SendKeys("Korean");
                    IWebElement languagelevel = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
                    languagelevel.Click();
                    IWebElement basiclevel = driver.FindElement(By.XPath("//*[contains(@value,'Basic')]"));
                    basiclevel.Click();
                    IWebElement addlangbtn = driver.FindElement(By.XPath("//div[@class ='six wide field']/child::input[@value ='Add']"));
                    addlangbtn.Click();
               
            
        }

        internal void ValidateTheLanguageAdded()

        {

            rows = driver.FindElements(By.XPath("//table[@id='account-profile-section']/tbody/tr")).Count;

            for (int i = 1; i <= rows; i++)
            {
                var langtext = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                Assert.That(langtext.Text, Is.EqualTo("Korean"));
            }
           
        }

        
        internal void EditTheExistingLanguage()
        {
            IWebElement writebtn = driver.FindElement(By.XPath("//td[text()='Korean' ]/following-sibling::td[text()='Basic']/following-sibling::td[@class='right aligned']/child::span[@class='button']/child::i[@class='outline write icon']"));
            writebtn.Click();
            IWebElement editlangtext = driver.FindElement(By.XPath("//input[@value='Korean']"));
            editlangtext.Clear();
            editlangtext.SendKeys("Thai");
            IWebElement editleveldropdown = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            editleveldropdown.Click();
            IWebElement fluentlevel = driver.FindElement(By.XPath("//*[contains(@value,'Fluent')]"));
            fluentlevel.Click();
            IWebElement updatebtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            updatebtn.Click();
            Thread.Sleep(10000);

        }

        
        internal void ValidateTheLanguageEdited()
        {
                IWebElement editedlevel = driver.FindElement(By.XPath("//td[text()='Thai']/following-sibling::td[text()='Fluent']"));
                IWebElement editedlanguage = driver.FindElement(By.XPath("//td[text()='Fluent']/preceding-sibling::td[text()='Thai']"));
                Assert.That(editedlanguage.Text, Is.EqualTo("Thai"));
                Assert.That(editedlevel.Text, Is.EqualTo("Fluent"));
        }

        internal void DeleteTheExistingLanguage()
        {
            IWebElement removebtn = driver.FindElement(By.XPath("//td[text()='English']/following-sibling::td[text()='Basic']/following-sibling::td/child::span/child::i[@class='remove icon']"));
            removebtn.Click();
        }

        internal void ValidateTheLanguageDeletion()
        {
            for (int i = 1; i <= rows; i++)
            {
                var langtext = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                Assert.That(langtext.Text, Is.Not.EqualTo("English"));
            }
        }
        //EDUCATION MODULE
        internal void ClickEducation()
        {
            Thread.Sleep(10000);
            IWebElement educationbtn = driver.FindElement(By.XPath("//a[@class='item'][text()='Education']"));
            educationbtn.Click();
        }

        IWebElement graduationyeardropdownbtn => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        
        internal void AddNewEducation(string s1,string s2)
        {
            //Checking for duplicate data
            Boolean isPresent = driver.FindElements(By.XPath("//td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td")).Count() > 0;
            Boolean isPresent2 = driver.FindElements(By.XPath("//td[text()='India']/following-sibling::td[text()='Kakatiya']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='CSE']/following-sibling::td")).Count() > 0;
            //Adding the Education if the information is not existed already
            if ((isPresent == false) || (isPresent2 == false))
            {
                IWebElement addneweducationbtn = driver.FindElement(By.XPath("//th[text()='Graduation Year']/following-sibling::th[@class='right aligned']/child::div[text()='Add New']"));
                addneweducationbtn.Click();
                IWebElement universitytxt = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                universitytxt.SendKeys(s1);
                IWebElement countrydropdownbtn = driver.FindElement(By.XPath("//select[@name='country']"));
                countrydropdownbtn.Click();
                IWebElement countrybtn = driver.FindElement(By.XPath("//option[@value='India']"));
                countrybtn.Click();
                IWebElement titledropdownbtn = driver.FindElement(By.XPath("//select[@name='title']"));
                titledropdownbtn.Click();
                IWebElement titlebtn = driver.FindElement(By.XPath("//option[@value='B.Tech']"));
                titlebtn.Click();
                IWebElement degreetxt = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                degreetxt.SendKeys(s2);
                //IWebElement graduationyeardropdownbtn = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                graduationyeardropdownbtn.Click();
                IWebElement graduationyearbtn = driver.FindElement(By.XPath("//option[@value='2014']"));
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
        IWebElement gradyear => driver.FindElement(By.XPath("//tr/child::td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td"));

        internal void ValidateTheEducationAdded()
        {
             Thread.Sleep(10000);
             Assert.That(gradyear.Text, Is.EqualTo("2014"));
        }

        internal void EditTheExistingEducation()
        {
            IWebElement eduwriteicon = driver.FindElement(By.XPath("//td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td[text()='2014']/following-sibling::td/child::span/child::i[@class='outline write icon']"));
            eduwriteicon.Click();
            
            //Clicking on graduation year button
            graduationyeardropdownbtn.Click();

            //updating graduation year to 2016
            driver.FindElement(By.XPath("//option[@value='2016']")).Click();
            IWebElement updateedubtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateedubtn.Click();
            Thread.Sleep(10000);
        }

        internal void ValidateTheEducationEdited()
        {
            
            IWebElement editededucation = driver.FindElement(By.XPath("//td[text()='India']/following-sibling::td[text()='JNTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td"));
            Assert.That(editededucation.Text, Is.EqualTo("2016"));
            

        }

        internal void DeleteTheExistingEducation()
        {
            Thread.Sleep(15000);
            IWebElement eduremoveicon = driver.FindElement(By.XPath("//td[text()='India']/following-sibling::td[text()='Kakatiya']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='CSE']/following-sibling::td/following-sibling::td/child::span/following-sibling::span/child::i[@class='remove icon']"));
            eduremoveicon.Click();
        }

        internal void ValidateTheEducationDeletion()
        {
            Thread.Sleep(15000);
            Boolean edudelete = driver.FindElements(By.XPath("//tr/child::td[text()='India']/following-sibling::td[text()='Kakatiya']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='CSE']/following-sibling::td[text()='2014']")).Count() > 0;
            Assert.That(edudelete, Is.False);

        }
        //SKILLS MODULE
        internal void ClickSkills()
        {
            IWebElement skillbtn = driver.FindElement(By.XPath("//a[@class='item'][text()='Skills']"));
            skillbtn.Click();
        }

        internal void AddNewSkill(string ski)
        {
            Boolean isSkillAlreadyPresent = driver.FindElements(By.XPath("//td[text()='Cooking']")).Count > 0; 
                if(isSkillAlreadyPresent == true)
                {
                    Console.WriteLine("Cant add Skill as it is already present");
                }
                else
                {
                    IWebElement addnewskillbtn = driver.FindElement(By.XPath("//th[text()='Skill']/following-sibling::th[text()='Level']/following-sibling::th[@class='right aligned']/child::div[text()='Add New']"));
                    addnewskillbtn.Click();
                    IWebElement addskill = driver.FindElement(By.XPath("(//input[@placeholder='Add Skill'])"));
                    addskill.SendKeys(ski);
                    IWebElement skilllevel = driver.FindElement(By.XPath("//select[@name='level']"));
                    skilllevel.Click();
                    IWebElement beginnerlevel = driver.FindElement(By.XPath("//*[contains(@value,'Beginner')]"));
                    beginnerlevel.Click();
                    IWebElement addskillbtn = driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/child::input[@value='Add']"));
                    addskillbtn.Click();
                }

            
        }

        internal void ValidateTheSkillAdded()

        {

            IWebElement addedskill = driver.FindElement(By.XPath("//td[text()='Cooking']"));
            Assert.That(addedskill.Text, Is.EqualTo("Cooking"));


        }


        internal void EditTheExistingSkill()
        {
            IWebElement skillwritebtn = driver.FindElement(By.XPath("//td[text()='Dancing' ]/following-sibling::td[text()='Beginner']/following-sibling::td[@class='right aligned']/child::span[@class='button']/child::i[@class='outline write icon']"));
            skillwritebtn.Click();
            IWebElement editskilltext = driver.FindElement(By.XPath("//input[@value='Dancing']"));
            editskilltext.Clear();
            editskilltext.SendKeys("Teaching");
            IWebElement editskillleveldropdown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            editskillleveldropdown.Click();
            IWebElement intermediatelevel = driver.FindElement(By.XPath("//*[contains(@value,'Intermediate')]"));
            intermediatelevel.Click();
            IWebElement skillupdatebtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            skillupdatebtn.Click();
            Thread.Sleep(10000);

        }


        internal void ValidateTheSkillEdited()
        {
            IWebElement editedskilllevel = driver.FindElement(By.XPath("//td[text()='Teaching']/following-sibling::td"));
            IWebElement editedskill = driver.FindElement(By.XPath("//td[text()='Intermediate']/preceding-sibling::td[text()='Teaching']"));
            Assert.That(editedskill.Text, Is.EqualTo("Teaching"));
            Assert.That(editedskilllevel.Text, Is.EqualTo("Intermediate"));
        }

        internal void DeleteTheExistingSkill()
        {
            Thread.Sleep(10000);
            IWebElement skillremovebtn = driver.FindElement(By.XPath("//td[text()='Cooking']/following-sibling::td[text()='Beginner']/following-sibling::td/child::span/following-sibling::span/child::i[@class='remove icon']"));
            skillremovebtn.Click();
        }

        internal void ValidateTheSkillDeletion()
        {
            Thread.Sleep(10000);
            Boolean isSkillDeleted = driver.FindElements(By.XPath("//td[text()='Cooking']/following-sibling::td[text()='Beginner']")).Count > 0;
            Assert.That(isSkillDeleted, Is.False);
        }

    }
}