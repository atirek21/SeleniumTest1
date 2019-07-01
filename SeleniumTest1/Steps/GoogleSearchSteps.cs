using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumTest1.Action;
using SeleniumTest1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace WebdriverBdd
{
    [Binding]
    public class GoogleSearchStep
    {
        public GoogleHomePageAction googleHomePageAction = new GoogleHomePageAction();

        [BeforeScenario]
        public void BeforeScenario()
        {
            BrowserDriver.InitialiseBrowser();
        }

        [Given(@"I am on Google search page")]
        public void IamOnGoogleSearchPage()
        {
            BrowserDriver.webDriver.Navigate().GoToUrl("http://google.com");
        }

        [When(@"I search '(.*)' in search field")]
        public void WhenIEneteredIntoThePayeeNameField(string keyword)
        {
            googleHomePageAction.SearchKeyword(keyword);
        }

        [Then(@"I should see '(.*)' links returned in the first search page")]
        public void ThenIShouldSeeLinksReturnedInTheFirstSearchPage(int numberOfLinks)
        {
            int actualNumberOfLinks = googleHomePageAction.GetNumberOfLinks();
            BrowserDriver.TakeScreenshot();
            Assert.AreEqual(numberOfLinks, actualNumberOfLinks, "Number of links don't match with the expected links");
        }

        [Then(@"Fetch the fifth link text")]
        public void ThenFetchTheFifthLinkText()
        {
            string linkText = "The number of links returned is less than 5.";
            if(googleHomePageAction.GetNumberOfLinks() > 5)
            {
                linkText = googleHomePageAction.GetLinkTextForIndex(4);
            }
            Console.WriteLine("The fifth link text in Google search page is : " + linkText);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BrowserDriver.DisposeBrowser();
        }
    }
}
