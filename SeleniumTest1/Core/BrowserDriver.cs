﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Drawing.Imaging;
using System.IO;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest1.Core
{
    public class BrowserDriver
    {
        public static IWebDriver webDriver;


        public static void InitialiseBrowser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        public static void DisposeBrowser()
        {
            webDriver.Close();
            webDriver.Dispose();
        }
    }
}
