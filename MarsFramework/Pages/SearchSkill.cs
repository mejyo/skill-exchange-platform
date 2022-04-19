using MarsFramework.Global;
using NUnit.Framework;
using OpenDialogWindowHandler;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class SearchSkill
    {


        public SearchSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on SearchSkill
        [FindsBy(How = How.CssSelector, Using = ".search.link.icon")]
        private IWebElement SearchSkillButton { get; set; }


        [FindsBy(How = How.LinkText, Using = "Business")]
        private IWebElement Category { get; set; }

        [FindsBy(How = How.LinkText, Using = "Other")]
        private IWebElement SubCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Online']")]
        private IWebElement Online { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Onsite']")]
        private IWebElement Onsite { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[normalize-space()='ShowAll'])[1]")]
        private IWebElement ShowAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Varsha Catering']")]
        private IWebElement User { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[normalize-space()='Online']")]

        private IWebElement LocationType { get; set; }

        internal void SearchSkillFunction()
        {
            var wait = new WebDriverWait(GlobalDefinitions.driver, new TimeSpan(0, 0, 30));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".search.link.icon")));

            SearchSkillButton.Click();


            Category.Click();


            SubCategory.Click();


            Online.Click();

            Onsite.Click();

            ShowAll.Click();

            Thread.Sleep(3000);

            User.Click();

            Thread.Sleep(3000);


            String actualMessage = LocationType.Text;
            String expectedMessage = "Online";


            GlobalDefinitions.VerifySuccessfulMessage(expectedMessage, actualMessage, "Search Skill");




        }

    }
}