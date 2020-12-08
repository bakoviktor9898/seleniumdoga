using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace BakoViktorDoga
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver dw = new FirefoxDriver();

            dw.Navigate().GoToUrl("http://atthy4.atspace.cc/seleniumdoga/Hivatalosdoga.html");
            dw.Manage().Window.Maximize();

            dw.FindElement(By.LinkText("DevOps 1")).Click();

            dw.Navigate().Back();
            // 2 feladat ket jatekos
            var drop = dw.FindElement(By.Name("visitor[b]"));
            var select = new SelectElement(drop);
            var drop2 = dw.FindElement(By.Name("visitor[a]"));
            var select2 = new SelectElement(drop2);
            select.SelectByIndex(3);
            select2.SelectByIndex(4);
            //2. feladat checkboxos
            IWebElement checkbox = dw.FindElement(By.Id("checkbox_car"));
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }

            Assert.IsTrue(checkbox.Selected);

            // 3 feladat
            

            //4 feladat
            IWebElement elem = dw.FindElement(By.XPath("/html/body/button"));
            elem.Click();
            Assert.AreEqual("Minden Pontot megszerzek", dw.Title);

            //5.
            var radio = dw.FindElement(By.Id("radio_kivalo"));
            radio.Click();
            Assert.IsFalse(dw.FindElement(By.Id("radio_jeles")).Selected);

            dw.FindElement(By.TagName("button")).Click();
            int kepek = dw.FindElements(By.TagName("img")).Count;
            Assert.IsTrue(kepek==2);
        }
    }
}
