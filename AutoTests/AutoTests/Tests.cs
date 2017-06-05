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
            Assert.That("abbbbbcde", Does.Match("ab*cde"));
            Assert.That("acde", Does.Match("ab*cde"));
        }
        [Test]
        public void FirstTestYavlena()
        {
            String url = "https://yavlenawebsite.melontech.com/69276";
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1024, 968);
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            Assert.That(driver.Url, Is.EqualTo(url));
            Assert.That(driver.Title, Does.Match(".* ID [0-9]{5} \\| Явлена"));
            StringAssert.IsMatch(".* ID [0-9]{5} \\| Явлена", driver.Title);

            Assert.That(driver.Url, Does.Not.EndWith(".com"));
            Assert.That(driver.Title, Does.Contain("Явлена"));
            Assert.That(driver.Title, Does.Match("Явлена"));

            driver.Close();
            driver.Quit();
        }
        [Test]
        public void YavlenaSocialFF()
        {
            String url = "https://yavlenawebsite.melontech.com/69276";
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Size = new System.Drawing.Size(1280, 968);
            driver.Navigate().GoToUrl(url);
            IWebElement socialHeading = driver.FindElement(By.CssSelector("div.social-block h4"));
            String socialHeadingText = socialHeading.Text;
            Assert.That(socialHeadingText, Is.EqualTo("Следвайте ни"));
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

