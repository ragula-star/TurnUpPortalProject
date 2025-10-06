using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Tests.Pages
{
    public class HomePage
    {

        
        public void NavigateToTMPage(IWebDriver driver)


        {
            IWebElement administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administration.Click();


            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
        }
    }
}