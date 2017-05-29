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
    public class Tests
    {
        public void EndDriver(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("map-search")).Click();
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
            EndDriver(driver);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(2 + 2, 4);
            Assert.That(2 + 2, Is.EqualTo(4));

            StringAssert.EndsWith("BCD", "ABCD");
            Assert.That("ABCD", Does.EndWith("BCD"));

            StringAssert.Contains("BC", "ABCD");
            Assert.That("ABCD", Does.Contain("BC"));

            Assert.GreaterOrEqual(567, 100);
            Warn.Unless(567, Is.GreaterThanOrEqualTo(1100), "FAILINGGGG");
            Warn.If(567, Is.GreaterThanOrEqualTo(1100), "Should be passing");

            Assert.That(new int[] { 1, 2, 3 }, Has.All.Positive);
        }
        [Test]
        public void FirstTestYavlena()
        {

            String url = "https://yavlenawebsite.melontech.com";
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1024, 968);
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);

            Assert.That(driver.Url, Is.EqualTo(url));

            Assert.That(driver.Url, Does.EndWith(".com"));
            Assert.That(driver.Title, Does.Contain("Явлена"));

            driver.FindElement(By.ClassName("map-search")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);

            driver.Close();
            driver.Quit();
        }

        [Test]
        public void Lesson2HoomeWork()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("map-search")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("brand")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("searchBox")).Click();
            driver.FindElement(By.Id("searchBox")).SendKeys("Sofia");
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
           
        }

 
        [Test]
        public void NewHome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            
            var element = driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/h1"));               // scrolling
            OpenQA.Selenium.Interactions.Actions actions = new Actions(driver);                            // scrolling
            actions.MoveToElement(element);                                                                // scrolling
            actions.Perform();                                                                             // scrolling
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("hide-cookies-message")).Click();                              //accept cookies
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/h1")).Click();
            Thread.Sleep(3000);
            bool isElementDisplayed=driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div[1]/div/p")).Displayed;       // verify message is displayed
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }

        [Test]
        public void AllCitiesSs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("hide-cookies-message")).Click();                              //accept cookies
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".all-cities.cities-btn")).Click();
            Thread.Sleep(3000);

            IWebElement body = driver.FindElement(By.XPath("//*[contains(text(),'Царево')]"));       //open link in new tab
            body.SendKeys(Keys.Control.ToString() + 't');                                            //open link in new tab
            Actions action = new Actions(driver);                                                    //open link in new tab
            action.KeyDown(Keys.Control).MoveToElement(body).Click().Perform();                      //open link in new tab


            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());                       // switch tab
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".view-mode:nth-child(1)")).Click();                // view by list
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("[href*='/broker/sendmessageforproperty?brokerId=FB2CD300-4BF0-43C5-953D-750ACD624169&serviceId=6df97f77-0b50-45d7-81b6-29c7873acc85']")).Click();
            driver.Close();
            driver.Quit();

        }
        [Test]
        public void HW1Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("searchBox")).SendKeys("София");
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            Thread.Sleep(1000);
            Assert.AreEqual(driver.Url, "https://yavlenawebsite.melontech.com/properties/all/%D0%A1%D0%BE%D1%84%D0%B8%D1%8F%20(%D1%81%D1%82%D0%BE%D0%BB%D0%B8%D1%86%D0%B0)/%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/?view=Hybrid");
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void HW2Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist/");
            driver.Manage().Window.Maximize();
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
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void HW3Dido()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/ html / body / div[2] / div / section[1] / aside[1] / nav / ul / li[5] / a")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact.GiveARentProperty")).Selected, true);
            driver.Close();
            driver.Quit();

        }
        [Test]
        public void HWPeter1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a.dropdown-trigger")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("span.text-value")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[2]/div/div/a")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("button.green-btn")).Click();
            
        }
        [Test]
        public void HWPeter2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Пазарни проучвания")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//form[@id='contact-owner']/div[3]/div/label[6]/div/ins"));
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact_MarketAnalysis")).Selected, true);
            driver.Close();
            driver.Quit();
        }

    }
}

