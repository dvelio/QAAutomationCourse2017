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
        IWebDriver driver;
        [TearDown]
        public void EndDriver()
        {
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("map-search")).Click();
            driver.FindElement(By.ClassName("dropdown-trigger")).Click();
            Thread.Sleep(3000);
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
            driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1024, 968);
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            Assert.That(driver.Url, Is.EqualTo(url));
            Assert.That(driver.Title, Does.Match(".* ID [0-9]{5} \\| Явлена"));
            StringAssert.IsMatch(".* ID [0-9]{5} \\| Явлена", driver.Title);

            Assert.That(driver.Url, Does.Not.EndWith(".com"));
            Assert.That(driver.Title, Does.Contain("Явлена"));
            Assert.That(driver.Title, Does.Match("Явлена"));
        }
        [Test]
        public void YavlenaSocialFF()
        {
            String url = "https://yavlenawebsite.melontech.com/69276";
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Size = new System.Drawing.Size(1280, 968);
            driver.Navigate().GoToUrl(url);
            IWebElement socialHeading = driver.FindElement(By.CssSelector("div.social-block h4"));
            String socialHeadingText = socialHeading.Text;
            Assert.That(socialHeadingText, Is.EqualTo("Следвайте ни"));
        }    
                
        [Test]
        public void HWPeter1()
        {
            driver = new ChromeDriver();
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
            driver = new ChromeDriver();
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

