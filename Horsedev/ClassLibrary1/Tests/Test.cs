using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Parallelizable(ParallelScope.All)] //for running tests in parallel
    public class Test
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
        public void AddnValidateTM()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            timenMaterialPage.CreateNewRecord();
            timenMaterialPage.ValidateCreatedRecord();


        }
        [Test]
        public void EditRecordnValidate()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            timenMaterialPage.EditRecord();
            timenMaterialPage.ValidateEditedRecord();
        }
        [Test]
        public void DeleteRecordnValidate()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            timenMaterialPage.DeleteRecord();
            timenMaterialPage.ValidateDeletedRecord();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

   
}
