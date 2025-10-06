using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Tests.Pages
{
    public class LoginPage
    {

        
        public void LoginActions(IWebDriver driver)
        {
           driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
            driver.Manage().Window.Maximize();


             
            IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
            usernametextbox.SendKeys("hari");

            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");

            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();
        }


    }
}
