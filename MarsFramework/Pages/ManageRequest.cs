using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using static NUnit.Core.NUnitFramework;

using System.Threading;
using MarsFramework.Global;

namespace MarsFramework.Pages
{
    internal class ManageRequest
    {

        public ManageRequest()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }
        //Click on Manage Request tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui eight item menu']/div[@class='ui dropdown link item']") ]         
        private IWebElement ManageRequestsTab { get; set; }

        //Click on Recieved Requests in dropdown
        [FindsBy(How = How.LinkText, Using = "Received Requests")]
        private IWebElement RecievedRequestsOption { get; set; }

        //Click on Sent Requests in dropdown
        [FindsBy(How = How.LinkText, Using = "Sent Requests")]
        private IWebElement SentRequestsOption { get; set; }

        //Click on Title Service Link on Recieved
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[2]/a")]
        private IWebElement RecTitleServiceLink { get; set; }
       
        //Click on Sender Profile Link Requests 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[4]/a")]
        private IWebElement SenderProfileLink { get; set; }

        //Click on Title Service Link on Sent
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement SentTitleServiceLink { get; set; }

        //Click on Recipient Profile Link 
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement RecipientProfileLink { get; set; }

        //Click on Completed Action 
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement CompletedAction { get; set; }

        //Click on Withdraw Action 
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement WithdrawAction { get; set; }

        //Click on Review Action 
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement ReviewAction { get; set; }

        //Click on Page Navigate 
        [FindsBy(How = How.XPath, Using = "//td[@class='two wide']/button[@type='button'][@class='ui negative basic button']")]
        private IWebElement NextPage { get; set; }

        //Title of the Page 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/h2")]
        private IWebElement TitleOnPage { get; set; }

        //Find All Row
        [FindsBy(How = How.XPath, Using = "//table[@class='ui single line sortable striped table sortableHeader']/tbody/tr")]
        private IList<IWebElement> rows { get; set; }

        //Find All Coloumn
        [FindsBy(How = How.XPath, Using = "//table[@class='ui single line sortable striped table sortableHeader']/tbody/tr/td")]
        private IList<IWebElement> Coloumn { get; set; }

        //Find Message
        [FindsBy(How = How.ClassName, Using = "ns-box-inner")]
        private IWebElement Message { get; set; }

        public string ExpectedMsg;
        public string ActualMsg;


        internal void GoToRecievedRequestsPage()
        {
            ManageRequestsTab.Click();
            GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, By.XPath("/html/body/div[1]/div/section[1]/div/div[1]/div/a[1]"), 5);
            RecievedRequestsOption.Click();
            Thread.Sleep(1000);
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/h2"), 10);
            ExpectedMsg = "Received Requests";
            ActualMsg = TitleOnPage.Text;
        }
        internal void RecievedAction()
        {
            Thread.Sleep(1000);
            IList<IWebElement> PageNavigation = GlobalDefinitions.driver.FindElements(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/button"));
            
            //Click on Accept or complete button)
            for (int j = 2; j < PageNavigation.Count; j++)
            {
                int TotalRow = rows.Count;
                for (int i = 1; i <=TotalRow; i++)
                {   
                    IWebElement Action = GlobalDefinitions.driver.FindElement(By.XPath("/ html / body / div / div / div / div[2] / div[1] / table / tbody / tr[" + i + "] / td[8]"));
                    if (Action.Text.Contains("Accept"))
                    {
                        Action.FindElement(By.XPath("//button[@type='button'][@class='ui primary basic button']")).Click();
                        GlobalDefinitions.wait(1);
                        ExpectedMsg = "Service has been updated";
                        GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                        ActualMsg = Message.Text;
                        GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg, ActualMsg, "Action Accept");
                    }
                    else
                    {
                        if (Action.Text == "Complete")
                        {
                            Action.Click();
                            ExpectedMsg = "Request has been updated";
                            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                            ActualMsg = Message.Text;
                            GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg,ActualMsg, "Action Complete");
                            Thread.Sleep(1000);
                            
                        }
                    }
                    TotalRow = rows.Count;
                    
                }

                //Click on next page
                IWebElement PageNext = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/button[" + (j + 1) + "]"));
                if(PageNext.Enabled)
                {
                    PageNext.Click();
                }
            }           

        }

        internal void GoToSentRequests()
        {
            Thread.Sleep(1000);
            ManageRequestsTab.Click();
            SentRequestsOption.Click();
            Thread.Sleep(1000);
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html/body/div/div/div/div[2]/h2"), 10);
            ExpectedMsg = "Sent Requests"; ;
            ActualMsg = TitleOnPage.Text;

        }
        internal void SentAction()
        {
            Thread.Sleep(1000);
            IList<IWebElement> PageNavigation = GlobalDefinitions.driver.FindElements(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/button"));
            
            //Click on Withdraw or completed button)
            for (int j = 2; j<PageNavigation.Count; j++)
            {
                int TotalRow = rows.Count;
                for (int i = 1; i <=TotalRow; i++)
                {   
                    IWebElement Action = GlobalDefinitions.driver.FindElement(By.XPath("/ html / body / div / div / div / div[2] / div[1] / table / tbody / tr[" + i + "] / td[8]"));
                    if (Action.Text.Contains("Withdraw"))
                    {
                        Action.FindElement(By.XPath("//button[@type='button'][@class='ui negative basic button']")).Click();
                        GlobalDefinitions.wait(1);
                        ExpectedMsg = "Request has been withdrawn";
                        GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                        ActualMsg = Message.Text;
                        GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg, ActualMsg, "Action Withdraw");
                     }
                    else
                    {
                        if (Action.Text == "Completed")
                        {
                            Action.Click();
                            ExpectedMsg = "Request has been updated";
                            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                            ActualMsg = Message.Text;
                            GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg, ActualMsg, "Action Completed");
                            Thread.Sleep(1000);
                            
                        }
                    }
                    TotalRow = rows.Count;
                    
                }

                //Click on next page
                IWebElement PageNext = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/button[" + (j + 1) + "]"));
                if (PageNext.Enabled)
                {
                         PageNext.Click();
                }
            }           

        }          
       
    }
}
