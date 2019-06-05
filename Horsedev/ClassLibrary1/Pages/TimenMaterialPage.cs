using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    internal class TimenMaterialPage
    {
        private IWebDriver driver;

        public TimenMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement CreateNewBtn => driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
        IWebElement CodeTxt => driver.FindElement(By.XPath("//input[@id='Code']"));
        IWebElement DescText => driver.FindElement(By.XPath("//input[@id='Description']"));
        IWebElement SaveBtn => driver.FindElement(By.XPath("//input[@id='SaveButton']"));

        internal void CreateNewRecord()
        {
            // logic to create a new record
            CreateNewBtn.Click();
            CodeTxt.SendKeys("test_001");
            DescText.SendKeys("Desc");
            SaveBtn.Click();
        }
        IWebElement nextPagebtn => driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]"));

        internal void ValidateCreatedRecord()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Go to the next page')]")));

            //Thread.Sleep(3000);Explicit wait
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        var codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                        Console.WriteLine(codeText);

                        if (codeText == "test_001")
                        {
                            Console.WriteLine("Test Passed");
                            return;
                        }
                        //clicking on GotothenextPage button
                        nextPagebtn.Click();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Test Failed with " + e);
            }
        }
//IWebElement lastPagebtn => driver.FindElement(By.XPath("//span[contains(.,'Go to the last page')]"));
        internal void DeleteRecord()
        {
           // lastPagebtn.Click();
            IWebElement DeleteBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[2]"));
            DeleteBtn.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Alert().Accept();
        }
        internal void ValidateDeletedRecord()
        {
            
        }

        internal void EditRecord()
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            //IWebElement nextPageWait = wait.until(ExpectedConditions.ElementToBeClickable(By.XPath(")
            Thread.Sleep(3000); 

            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        var codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                        Console.WriteLine(codeText);
                       
                        IWebElement EditBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[" + i + "]/td[5]/a[1]"));


                        if (codeText == "test_001")
                        {
                            
                            EditBtn.Click();
                            Thread.Sleep(3000);
                            DescText.Clear();
                            DescText.SendKeys("Descript");
                            SaveBtn.Click();
                            return;
                        }
                        //clicking on GotothenextPage button
                        nextPagebtn.Click();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to Edit Record.Test Failed with " + e);
            }
        }
        internal void ValidateEditedRecord()
        {
            Thread.Sleep(3000);

            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        var codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                        var DescriptionText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]")).Text;
                        Console.WriteLine(DescriptionText);
                        

                        if (codeText == "test_001" & DescriptionText == "Descript")
                        {

                            Console.WriteLine("Test Passed");
                            return;
                        }
                        //clicking on GotothenextPage button
                        nextPagebtn.Click();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Test Failed with " + e);
            }
        }

    }
}