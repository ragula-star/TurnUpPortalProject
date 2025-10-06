using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Tests.Utilities;

namespace TurnUpPortal.Tests.Pages
{
    public class TimeandMaterialModule
    {
        public void CreateTimeRecord(IWebDriver driver)

        { 

            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();

            
            IWebElement timecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timecodedropdown.Click();

            
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TA Programme");

            
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("This is description!");

           
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("101");

            
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();

            Wait.WaitToBeClickable("XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "TA Programme")
            {
                Assert.Pass("Time record created successfully");
            }

            else
            {
                Assert.Fail("Time record has not been created");
            }
        }

        public void EditTimeRecord(IWebDriver driver)
        {
            
            Wait.WaitToBeClickable("XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();


            
            Wait.WaitToBeClickable("XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();

            
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.Clear();
            priceTagOverlap.Click();
            priceTextbox.SendKeys("50");

            
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();



            

            Wait.WaitToBeClickable("XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            IWebElement navigateToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            navigateToLastPage.Click();

            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            if (newPrice.Text == "$50.00")
            {
                Assert.Pass("Time record edited successfully");
            }

            else
            {
                Assert.Fail("Time record has not been edited");
            }




        }

        public void DeleteTimeRecord(IWebDriver driver)

        {
            
            Wait.WaitToBeClickable("XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();

            
            IList<IWebElement> listItemsBefore = driver.FindElements(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr")).ToList();

            int afterDeletion = listItemsBefore.Count - 1;

            
            IWebElement lastItemBefore = listItemsBefore.Last();

           
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
             deleteButton.Click();

           
            lastItemBefore.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

            
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(3000);

           IList<IWebElement> listItemsAfter = driver.FindElements(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr")).ToList();

            
            //Assert.That(afterDeletion, Is.EqualTo(listItemsAfter.Count), "The last item was not deleted.");
            Assert.That(afterDeletion == listItemsAfter.Count, "The last item was not deleted.");




        }

    }

}
