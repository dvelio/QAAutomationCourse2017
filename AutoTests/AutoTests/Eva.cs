using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutoTests
{
    [TestFixture]
    public class Eva
    {
        public void EndDriver(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }
        public void implicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void HW2EDLocatorsByName()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            implicitWait(driver);
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            driver.FindElement(By.ClassName("icheckbox_flat-green")).Click();
            driver.FindElement(By.ClassName("green-btn")).Click();
            EndDriver(driver);
        }
        [Test]
        public void HW3EDCssSelectors()
        //Selected number 10125
        // 1. Opens the url
        // 2. Clicks on the respective Услуга, Тип имот, Вид имот, Област,  град depending on your number and choice of City
        // 3. Click on “Свържи се с брокер” button for the (preferably) second property in the list
        // Commit and push the test
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            implicitWait(driver);
            driver.FindElement(By.CssSelector("[href *= '/propertylist/sales/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div2/div/section/div/div/div/div/form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[2]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'к.к. Слънчев бряг')]")).Click();
            driver.FindElement(By.CssSelector("[href *= 'propertylist/sales/burgas/sunny-beach-resort-area/quarter/residentialproperties/room/seaside-holiday-property/']")).Click();
            driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/h1")).Click();
            EndDriver(driver);

        }
        [Test]
        public void HW4EDCssSelectors()
        //1.Open https://yavlenawebsite.melontech.com/service/
        //2. On the left there are links to different services
        //3. Click Rent 
        //4. After clicking on the link for the service new webpage is opened. On the newly opened page make sure the correct checkbox is ticked: next to the service you choose in the previous screen

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.FindElement(By.CssSelector("[href *= '/service/forrent']")).Click();
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact_PropertyAssessment")).Selected, true);
            EndDriver(driver);
        }

        //Optional Homework Week 5
       [Test]
       public void HW5EDHeaderLinks()
        //Choose at least 5 pages, and on each of them check all the Header links are present
        //Hint: use[TestCaseData] without ExpectedReuslt part.Pass the address of the page you are testing as String argument of the test.
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylis");
            implicitWait(driver);
            //check the elements in the Header
            Assert.AreEqual(driver.FindElement(By.CssSelector("a[href^='/properties/sales/София']")).GetAttribute("Продажба"),true);
            Assert.AreEqual(driver.FindElement(By.CssSelector("a[href^='/properties/rentals/']")).GetAttribute("Наем"), true);
            //Assert.AreEqual(driver.FindElement(By.CssSelector("a[href='/service']")));
            //Assert.AreEqual(driver.FindElement(By.CssSelector("a[href='/faq']")));
            //Assert.AreEqual(driver.FindElement(By.CssSelector("a[href='/about']")));
            //Assert.AreEqual(driver.FindElement(By.CssSelector("a[href='/contact']")));
            EndDriver(driver);
        }


    }
}
