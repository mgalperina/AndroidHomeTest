using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AndroidProject
{
    [TestClass]
    public class UnitTest1
    {

        AppiumDriver<IWebElement> driver;




        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "A1-810");
            cap.SetCapability("appActivity", "BrowserActivity");
            cap.SetCapability("app", "com.android.browser");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("platformVersion", "4.4.2");

            
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            driver.Navigate().GoToUrl("http://google.co.nz");

            //driver.FindElementByXPath(".//a[contains(text(), 'Māori')]").Click();
            //string maoriImages = driver.FindElementByClassName("gb_P").Text;
            //Assert.AreEqual("Atahonga", maoriImages);

            driver.FindElement(By.Name("q")).Click();
            driver.SendKeys("istqb");
            driver.FindElement(By.Id("_fZl")).Click();




                

        }
    }
}
