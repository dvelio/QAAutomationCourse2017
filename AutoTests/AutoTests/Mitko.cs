using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace AutoTests
{
    [TestFixture]
    [Author("Dimitar Velev", "dvelev@melontech.com")]
    public class Mitko
    {

        IWebDriver driver;
        [Test]
        [Category("Mitko Tests")]

        [TestCase("Chrome")]
        [TestCase("IE")]
        [TestCase("Mozilla")]



        public void HW1Mitko(string browserDriver)
        {
            switch (browserDriver)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Mozilla":
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            implicitWait(driver);
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            IWebElement propertyId = driver.FindElement(By.Id("searchBox"));
            Assert.That(propertyId.Displayed, Is.True, "Полето за търсене на имот съществува");
            driver.FindElement(By.Id("searchBox")).SendKeys("Pavlovo");
            driver.FindElement(By.XPath("//button[@data-search-field='new-search']")).Click();
            driver.FindElement(By.Id("searchBox-validation"));
            driver.FindElement(By.XPath("//*[@id='searchBox']")).Clear();
            driver.FindElement(By.XPath("//input[@placeholder='Изпиши град, квартал или ID на имот']")).SendKeys("Павлово");
            driver.FindElement(By.XPath("//*[text()='област София (столица), София, Павлово']")).Click();
            driver.FindElement(By.XPath("//button[@data-search-field='new-search']")).Click();
            driver.FindElement(By.XPath("//a[@alt='yavlena logo']")).Click();
            driver.FindElement(By.XPath("//a[@data-ga-action='Home Find On Map']")).Click();
            //testCleanup(driver);

        }

        [Test]
        [Category("Mitko Tests")]

        [TestCase("Chrome")]
        [TestCase("IE")]
        [TestCase("Mozilla")]

        public void HW3Mitko(string browserDriver)
        {
            switch (browserDriver)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Mozilla":
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist");
            driver.FindElement(By.XPath("//a[@href='/propertylist/sales/']")).Click();
            driver.FindElement(By.LinkText("Земя")).Click();
            driver.FindElement(By.XPath("//*[@href='/propertylist/sales/district/location/quarter/land/forest/']")).Click();
            driver.FindElement(By.LinkText("Габрово")).Click();
            driver.FindElement(By.XPath("//*[text()='Парцел']")).Click();
            driver.FindElement(By.LinkText("с. Длъгня")).Click();
            driver.FindElement(By.XPath("//*[@href='/broker/sendmessageforproperty?brokerId=08D83234-57C7-4E7D-B076-2985C37C294D&serviceId=c63ee654-d763-4f3c-8143-6b973e65ebff']")).Click();
            //testCleanup(driver);
        }



        [TearDown]
        public void testCleanup()
        {
            driver.Close();
            driver.Quit();
        }

        public void implicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        //public void multyDriver(string browserDriver)
        //{
        //    switch (browserDriver)
        //    {
        //        case "Chrome":
        //            driver = new ChromeDriver();
        //            break;
        //        case "IE":
        //            driver = new InternetExplorerDriver();
        //            break;
        //        case "Mozilla":
        //            driver = new FirefoxDriver();
        //            break;

        //        default:
        //            driver = new ChromeDriver();
        //            break;
        //    }
    }
}

