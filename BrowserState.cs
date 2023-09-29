// using System;
// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Firefox;
// using NUnit.Framework;
// using NUnit;

// namespace Selenium {

//     [TestFixture] 
//     public class BrowserState
//     {
//         public ChromeDriver driver;
        
//         [SetUp]  
//         public void Setup() 
//         {
//             driver = new ChromeDriver();
//             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
//             driver.Navigate().GoToUrl("https://skyscanner.com");
//         }

//         [TearDown] 
//         public void Teardown() 
//         {
//             Thread.Sleep(1000);
//             driver.Quit();
//         }   

//     }
// }