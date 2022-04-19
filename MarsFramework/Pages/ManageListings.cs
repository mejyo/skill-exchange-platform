using MarsFramework.Global;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Threading;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        public IWebElement manageListingsLink { get; set; }
                     
        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']/button[@class='ui icon positive right labeled button']")]
        private IWebElement clickActionsButton { get; set; }
     
        //Find All Row
        [FindsBy(How = How.XPath, Using = "//table[@class='ui striped table']/tbody/tr")]
        private IList<IWebElement> rows { get; set; }


        //Skill Title in View page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")]
        private IWebElement SkillTitle { get; set; }

        //Message
        [FindsBy(How = How.ClassName, Using = "ns-box-inner")]
        private IWebElement Message { get; set; }

        ShareSkill shareskill = new ShareSkill();
        public string ActualMsg;
        public string ExpectedMsg;
        int i;


        internal void Listing(string action)
        {
            manageListingsLink.Click();
            Thread.Sleep(1000);
            try
            {
                if (action == "add")
                {
                    shareskill.EnterShareSkill();
                    Thread.Sleep(500);
                    GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div[1]/div"), 5);
                    ExpectedMsg = "Service Listing added successfully";
                    ActualMsg = Message.Text;

                }
                else
                {
                    //Populate the Excel Sheet
                    GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
                    string ListingTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");


                    if (ListingTitle != null)
                    {

                        for (i = rows.Count; i >= 1; i--)
                        {

                            string title = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Text;
                            if (ListingTitle == title)
                            {

                                switch (action)
                                {
                                    case "delete":
                                        GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"), 5);
                                        IWebElement DeleteBtn = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"));
                                        DeleteBtn.Click();
                                        GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, By.XPath("//div[@class='actions']/button[@class='ui icon positive right labeled button']"), 5);
                                        clickActionsButton.Click();

                                        GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                                        ExpectedMsg = "Selenium has been deleted";
                                        ActualMsg = Message.Text;

                                        break;

                                    case "edit":
                                        GlobalDefinitions.wait(5);
                                        IWebElement EditBtn = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[2]"));
                                        EditBtn.Click();
                                        shareskill.EditShareSkill();
                                        GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div[1]/div"), 5);
                                        ExpectedMsg = "Service Listing updated successfully";
                                        ActualMsg = Message.Text;
                                        break;

                                    case "view":
                                        GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, By.XPath(" / html / body / div / div / div / div[2] / div[1] / div[1] / table / tbody / tr[" + i + "] / td[8] / div / button[1]"), 5);
                                        IWebElement ViewBtn = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[1]"));
                                        ViewBtn.Click();
                                        GlobalDefinitions.wait(3);
                                        ActualMsg = SkillTitle.Text;
                                        manageListingsLink.Click();
                                        Thread.Sleep(500);
                                        ExpectedMsg = "Selenium";
                                        break;
                                }
                            }
                            Thread.Sleep(500);
                        }
                    }

                }
            }
            catch(System.Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message);
            }
        }
       

    }
}
