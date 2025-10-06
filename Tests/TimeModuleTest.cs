using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TurnUpPortal.Tests.Pages;
using TurnUpPortal.Tests.Utilities;

namespace TurnUpPortal.Tests;

[TestFixture]
public class TimeModuleTests : CommonDriver
{


    [SetUp]
    public void Setup()
    {
        
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        driver = new ChromeDriver(options);

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

    }

    [Test]
    public void CreateTime_Test()
    {
        
        TimeandMaterialModule TimeandMaterialObj = new TimeandMaterialModule();
        TimeandMaterialObj.CreateTimeRecord(driver);

    }

    [Test]
    public void EditTime_Test()
    {
        
        TimeandMaterialModule TimeandMaterialObj = new TimeandMaterialModule();
        TimeandMaterialObj.EditTimeRecord(driver);
    }

    [Test]
    public void DeleteTime_Test()
    {

        
        TimeandMaterialModule TimeandMaterialObj = new TimeandMaterialModule();
        TimeandMaterialObj.DeleteTimeRecord(driver);
    }

    [TearDown]
    public void CloseTestRun()
    {
       driver.Quit();
    }

}
