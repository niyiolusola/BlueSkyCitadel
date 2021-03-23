﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace Longrichway21.Hooks
{
    [Binding]
    public sealed class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
