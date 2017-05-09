﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MyTest
{
    [TestFixture]
    public class Tests
    {
        private IWebElement element;

        public object KeyHandle { get; private set; }
        public object ActiveBrowser { get; private set; }

        [Test]
        public void Test1()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("map-search")).Click();
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void FirstTestYavlena()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
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
            IWebDriver driver = driver = new ChromeDriver();
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
        public void HomeWorkStefanS()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("област Пловдив, Пловдив");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void RentalsStefan()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/propertylist/");
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/']")).Click();
            driver.FindElement(By.XPath("//form/p[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[contains(text(),'Едностаен апартамент')]")).Click();
            driver.FindElement(By.XPath("//form/p[4]/a[5]")).Click();
            driver.FindElement(By.CssSelector("[href*='/propertylist/rentals/vidin/vidin/quarter/residentialproperties/onebedroomapartment/']")).Click();
            driver.FindElement(By.CssSelector(".green-btn")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }
        [Test]
        public void ZdelkaStefan()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/service/");
            driver.FindElement(By.XPath("//*[contains(text(),'Съдействие при сделка')]")).Click();
            driver.FindElement(By.XPath("//div/label[7]/div[@class='icheckbox_flat-green checked']"));

            driver.Close();
            driver.Quit();

        }
        [Test]
        public void Lesson2HomeWorkMitko()
        {
            IWebDriver driver = driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("Pavlovo");
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.Id("searchBox-validation"));
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).Clear();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("Павлово");
            //Thread.Sleep(3000);
            driver.FindElement(By.Id("ui-id-2")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon-search____ICON")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("brand")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.ClassName("map-search")).Click();
            //Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void Homework2EDLocatorsByName()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icheckbox_flat-green")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("icon - search____ICON")).Click();

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
            Assert.AreEqual(driver.FindElement(By.Id("OwnerContact_PropertyAssessment")).Selected, true);

        }
        [Test]
        public void HW4Dido()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com/broker/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".hide-cookies-message")).Click();
            driver.FindElement(By.CssSelector("a.green-btn:nth-child(1)"));            
            Thread.Sleep(1000);
            IList<IWebElement> List = driver.FindElements(By.CssSelector("article.broker-card h3.name a"));

            ArrayList NewList = new ArrayList();
            foreach (IWebElement UserName in List)
            {                 
                NewList.Add(UserName.Text);
                Console.WriteLine(NewList);
            }

            
            foreach (string Name in NewList)             
            {
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).Clear();                
                driver.FindElement(By.CssSelector("div.field.search-field input#searchBox")).SendKeys(Name);
                Thread.Sleep(1000);
                Assert.AreEqual(Name, driver.FindElement(By.CssSelector(".name > a:nth-child(1)")).Text);              
                Thread.Sleep(1000);

            }
        }

    }


}


