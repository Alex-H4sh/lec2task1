using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LecTask1
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;

        [TestInitialize]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Task1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Assert.IsFalse(!driver.Url.Contains("google.com"), "Wrong site");
        }

        [TestCleanup]
        public void close()
        {
            driver.Close();
        }
    }
}
