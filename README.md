## N.B.

Skyscanner has bot detection in place. This project is WIP and needs to implement the following first to get consistent runs.

[C# UndetectedChromeDriver](https://github.com/fysh711426/UndetectedChromeDriver)

## Installation Instructions

`dotnet new nunit`
`dotnet add package Selenium.WebDriver`

## Running Testcases
dotnet test


## Helpful Links

To start with, this projects README lists [here](https://github.com/quozd/awesome-dotnet/tree/master) an awesome set of resources to reference that are C# related, from books, to API libs, to AI stuff.

### Running Code

`dotnet run`

This does not execute NUnit tests

### Running Tests

`dotnet run`

OR

`dotnet run ./someDir/someTestFile.cs`

How to run a test [article](https://alteridem.net/2016/06/18/nunit-3-testing-net-core-rc2/)

### Configuration File Sample Set

[.runsettings](https://github.com/nunit/nunit3-vs-adapter/blob/master/.runsettings)


dotnet test ./BrowserState.cs  

dotnet clean

dotnet restore

## Bot Detection

A number of sites, inlcuding Skyscanner have bot detection in place. They do so by reading a number of header variables and monitoring the speed of test execution that does not match that of a normal user. 

See below some discussions on how to bypass this. These are options and not guaranteed. Some may also mess with your Chrome app settings and blow away your signed in accounts and set Chrome to be automation driven.

[How to Avoid Bot Detection with Selenium](https://www.zenrows.com/blog/selenium-avoid-bot-detection#cloudscraper)

[Selenium Undetected Chromedriver: Bypass Anti-Bots With Ease](https://scrapeops.io/selenium-web-scraping-playbook/python-selenium-undetected-chromedriver/#what-is-seleniums-undetected-chromedriver)

[How to avoid a bot detection and scrape a website using python?](https://stackoverflow.com/questions/68895582/how-to-avoid-a-bot-detection-and-scrape-a-website-using-python)

[Is there a version of Selenium WebDriver that is not detectable?](https://stackoverflow.com/questions/56528631/is-there-a-version-of-selenium-webdriver-that-is-not-detectable/56529616#56529616)

[Detecting Chrome Headless](https://antoinevastel.com/bot%20detection/2017/08/05/detect-chrome-headless.html)

[Selenium webdriver: Modifying navigator.webdriver flag to prevent selenium detection](https://stackoverflow.com/questions/53039551/selenium-webdriver-modifying-navigator-webdriver-flag-to-prevent-selenium-detec/53040904#53040904)

The following repo may help. It tries to keep up ith ChromeDriver as much as possible.

[Undetected ChromeDriver Python](https://github.com/ultrafunkamsterdam/undetected-chromedriver)
[Undetected ChromeDriver C# - Copy Of Python Version Above](https://github.com/fysh711426/UndetectedChromeDriver)

Sample Setup
```
{
        public ChromeDriver driver;
        public string jsExec = "Object.defineProperty(navigator, 'webdriver', {get: () => undefined})";
        
        [SetUp]  
        public void Setup() 
        {
            ChromeOptions options = new ChromeOptions();
            
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-blink-features=AutomationControlled");
            options.AddLocalStatePreference("excludeSwitches", "enable-automation");
            options.AddLocalStatePreference("useAutomationExtension", false);

            driver = new ChromeDriver(options=options);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript(jsExec);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            driver.Navigate().GoToUrl("https://skyscanner.com");


        }

        [TearDown] 
        public void Teardown() 
        {
            Thread.Sleep(1000);
            driver.Quit();
        }   

       

    }
```