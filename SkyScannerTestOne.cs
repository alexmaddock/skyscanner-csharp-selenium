using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using NUnit;

namespace Selenium {

    [TestFixture] 
    public class SeleniumTest : BrowserStateOne
    {

        [Test]
        public void VisitPage() 
        {
            var homePageTitle = driver.Title;
            StringAssert.Contains("YouTube", homePageTitle);

            var searchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            searchBox.Click();
            searchBox.SendKeys(" 9 Top Automated Testing Practices to Follow. ");
            var searchIcon = driver.FindElement(By.Id("search-icon-legacy"));
            searchIcon.Click();

            Thread.Sleep(5000);
            var titles = driver.FindElements(By.Id("video-title"));//.GetAttribute("innerText");

            // IList<IWebElement> titlesList = titles; // not needed

            foreach(IWebElement title in titles) {

                if(title.Text.Contains("9 Top Automated Testing Practices")) {
                    Console.WriteLine("Found matching text" + " " + title.Text + "Clicking it....");
                    title.Click();
                }
            }
            
            // Console.WriteLine(titleFind);
            // StringAssert.Contains(titleFind, "9 Top Automated Testing Practices to Follow.");
            // var textBox = driver.FindElementBy("originInput-input");
            // Assert.IsNotEmpty(textBox.GetAttribute("textContent"));
            // Assert.IsNotEmpty(textBox.GetAttribute("value"));
            
    
        }

    }
}