using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MyTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        //public void Test1()
        //{
        //    IWebDriver driver = driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
        //    driver.FindElement(By.ClassName("map-search"))
        //        .Click();
        //     driver.FindElement(By.ClassName("dropdown-trigger"))
        //        .Click();
        //     Thread.Sleep(3000);
        //     driver.Close();
        //    driver.Dispose();
        //}

        public void YavlenaFirstTestToFindElementsByClassName()
        {
            IWebDriver driver = driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yavlenawebsite.melontech.com");
            driver.FindElement(By.ClassName("map-search")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("icon-rent")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("clear-btn")).Click();
            Thread.Sleep(4000);
            driver.Close();
            driver.Dispose();
        }
    }
   
}