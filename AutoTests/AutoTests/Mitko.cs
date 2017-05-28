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
    public class Mitko
    {


        [Test]
        public void HW1Mitko()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            implicitWait(driver);
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            implicitWait(driver);
            driver.FindElement(By.Id("searchBox")).SendKeys("Pavlovo");
            implicitWait(driver);
            driver.FindElement(By.XPath("//button[@data-search-field='new-search']")).Click();
            implicitWait(driver);
            driver.FindElement(By.Id("searchBox-validation"));
            implicitWait(driver);
            driver.FindElement(By.XPath("//*[@id='searchBox']")).Clear();
            implicitWait(driver);
            driver.FindElement(By.XPath("//input[@placeholder='Изпиши град, квартал или ID на имот']")).SendKeys("Павлово");
            implicitWait(driver);
            driver.FindElement(By.XPath("//*[text()='област София (столица), София, Павлово']")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//button[@data-search-field='new-search']")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//a[@alt='yavlena logo']")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//a[@data-ga-action='Home Find On Map']")).Click();
            implicitWait(driver);
            testCleanup(driver);
        }

        [Test]
        public void HW3Mitko()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            driver.FindElement(By.XPath("//a[@href='/propertylist/sales/']")).Click();
            implicitWait(driver);
            driver.FindElement(By.LinkText("Земя")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//*[@href='/propertylist/sales/district/location/quarter/land/forest/']")).Click();
            implicitWait(driver);
            driver.FindElement(By.LinkText("Габрово")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//*[text()='Парцел']")).Click();
            implicitWait(driver);
            driver.FindElement(By.LinkText("с. Длъгня")).Click();
            implicitWait(driver);
            driver.FindElement(By.XPath("//*[@href='/broker/sendmessageforproperty?brokerId=08D83234-57C7-4E7D-B076-2985C37C294D&serviceId=c63ee654-d763-4f3c-8143-6b973e65ebff']")).Click();
            implicitWait(driver);
            testCleanup(driver);
        }


        public void testCleanup(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }

        public void implicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
