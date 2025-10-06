using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V137.Profiler;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Tests.Utilities
{
    public class Wait : CommonDriver
    {

       
        public static void WaitToBeClickable(string locatorType, string locatorValue, int seconds)

        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatorType == "XPath")
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }

    }
}