// using System;
// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Firefox;
// using NUnit.Framework;
// using NUnit;

// namespace Selenium {

//     [TestFixture] 
//     public class SeleniumTest : BrowserState
//     {

//         [Test]
//         public void VisitPage() 
//         {
//             var title = driver.Title;
//             StringAssert.Contains("Skyscanner", title);

//             var textBox = driver.FindElement(By.Id("originInput-input"));
//             // var textBox = driver.FindElementBy("originInput-input");
//             // Assert.IsNotEmpty(textBox.GetAttribute("textContent"));
//             // Assert.IsNotEmpty(textBox.GetAttribute("value"));
//             var submitButton = driver.FindElement(By.TagName("button"));
            
//             textBox.SendKeys("Selenium");
//             submitButton.Click();
            
//             var message = driver.FindElement(By.Id("message"));
//             var value = message.Text;
//         }

//     }
// }