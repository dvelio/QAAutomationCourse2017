using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
//D:\Philips\NUnit-Gui-0.3
namespace AutoTests
{
    [TestFixture]
    class SettingUpAndTearingDown
    {
        String fileName = "SettingUpAndTearingDown.log";
        [OneTimeSetUp]
        public void OneTimeSetup_()
        {
            File.AppendAllText(fileName, "OneTimeSetup_\r\n\r\n");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown_()
        {
            File.AppendAllText(fileName, "OneTimeTearDown_\r\n\r\n");
        }
        [SetUp]
        public void Setup_()
        {
            File.AppendAllText(fileName, "Setup_\r\n");
        }
        [TearDown]
        public void TearDown_()
        {
            File.AppendAllText(fileName, "TearDown_\r\n\r\n");
        }
        [Test, Ignore("Ignore a test")]
        public void Test1()
        {
            File.AppendAllText(fileName, "Test1\r\n");
        }
        [Test]
        public void Test2()
        {
            File.AppendAllText(fileName, "Test2\r\n");
        }
        [Test]
        [TestCase(12, 3, ExpectedResult = 4)]
        [TestCase(12, 4, ExpectedResult = 3)]
        [TestCase(12, 1, ExpectedResult = 4)]
        public int Ddiv(int a, int b)
        {
            return a/b;
        }
    }
}
