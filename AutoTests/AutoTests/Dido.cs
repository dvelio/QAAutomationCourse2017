using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutoTests
{
    [TestFixture]

    public class Didon4o

    {
        IWebDriver driver;
             
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void ResetDriver()
        {
            driver.Close();
            driver.Quit();
        }
       

        [Test, Author("Dido"), Description("Find element by ID and Class")]
        //[TestCase(BrowserList)]

        public void HW1_new()
        {
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.Id("searchBox")).SendKeys("София");
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            Thread.Sleep(900);
            Assert.AreEqual(driver.Url, "https://yavlenawebsite.melontech.com/properties/all/sofia/sofia/?view=Hybrid");
        }

        [Test, Author("Dido"), Description("Find element by Xpath")]
        
        public void HW2_new()
        {
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist/");
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[1]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[2]/a[4]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[3]/a[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[4]/a[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div/div/div/aside/form/p[5]/a[5]")).Click();
            driver.FindElement(By.CssSelector("#dea027c8-24d0-4197-9ec3-714423fca021 > a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#SenderName")).SendKeys("Дидо");
            driver.FindElement(By.CssSelector("#SenderPhone")).SendKeys("0888888888");
            driver.FindElement(By.CssSelector("#SenderEmail")).SendKeys("bla@abv.bg");
            driver.FindElement(By.CssSelector("#send-broker-message > div.modal-footer > input.green-btn")).Click();
        }
        [Test, Author("Dido"), Description("Assert")]
        public void HW3_new()
        {
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.FindElement(By.XPath("/ html / body / div[2] / div / section[1] / aside[1] / nav / ul / li[5] / a")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact.GiveARentProperty")).Selected, true);
        }

        [Test, Author("Dido"), Description("Search for specific broker")]
        public void HW4_new()
        {
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/broker/");
            driver.FindElement(By.CssSelector(".hide-cookies-message")).Click();
            Thread.Sleep(900);
            IList<IWebElement> List = driver.FindElements(By.CssSelector("article.broker-card h3.name a"));
            ArrayList NewList = new ArrayList();
            foreach (IWebElement UserName in List)
            {
                NewList.Add(UserName.Text);
            }
            foreach (string Name in NewList)
            {
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).Clear();
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).SendKeys(Name);
                Thread.Sleep(900);
                Assert.AreEqual(Name, driver.FindElement(By.CssSelector(".name > a:nth-child(1)")).Text);
            }

        }
    }
}
