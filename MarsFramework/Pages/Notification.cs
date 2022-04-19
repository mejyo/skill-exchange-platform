using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class Notification
    {

        public Notification()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Notification tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui compact menu']/div[@class='ui top left pointing dropdown item']")]
        private IWebElement NotificationTab { get; set; }
        
        //Click on Notification Title
        [FindsBy(How = How.XPath, Using = "//div[@class='seven wide column']/div[@class='ui items segment']/a[@class='item']")]
        private IWebElement TitleOnPage { get; set; }

        //Click on See ALL Link
        [FindsBy(How = How.LinkText, Using = "See All...")]
        private IWebElement SeeAllLink { get; set; }

        //Click on go to page Link
        [FindsBy(How = How.LinkText, Using = "Go to page")]
        private IWebElement GoToPage { get; set; }

        //Click on CheckBox 
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox'][@value ='0']")]
        private IWebElement CheckBox { get; set; }

        //Click on CheckBox 
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IList<IWebElement>   CheckBoxAll { get; set; }

        //Click on Select All 
        [FindsBy(How = How.XPath, Using = "//i[@class = 'mouse pointer icon']")]
        private IWebElement SelectAll { get; set; }

        //Click on Unsleect all 
        [FindsBy(How = How.XPath, Using = "//i[@class = 'ban icon']")]
        private IWebElement UnselectAll { get; set; }

        //Click on delete selected 
        [FindsBy(How = How.XPath, Using = "//i[@class = 'trash icon']")]
        private IWebElement DeleteSelected { get; set; }

        //Click on Check Mark selected as read 
        [FindsBy(How = How.XPath, Using = "//i[@class = 'check square icon']")]
        private IWebElement MarkSelectionAsRead { get; set; }

        //Click on Load More  
        [FindsBy(How = How.XPath, Using = "//span/div/div[@class='ui link item']/div")]
        private IWebElement Action { get; set; }

        //Click on Show Less Link 
        [FindsBy(How = How.XPath, Using = "//span/div/div[@class='ui link item']/div/center/a[@class='ui button']")]
        private IWebElement ShowLess { get; set; }

        //Click on Notification Option Link 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[2]/div/div/div/span/div/div[1]/div[4]/div/a/div[1]")]
        private IWebElement NotificationOption { get; set; }

        //Find Message
        [FindsBy(How = How.ClassName, Using = "ns-box-inner")]
        private IWebElement Message { get; set; }

        public string ExpectedMsg;
        public string ActualMsg;
        bool SelectedAll;
        bool UnselectedAll;
        int Count;
        internal void  GoToNotificationPage()
        {
            NotificationTab.Click();
            Thread.Sleep(500);
            SeeAllLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[@class='seven wide column']/div[@class='ui items segment']/a[@class='item']"), 10);
            ExpectedMsg = "Notifications";
            ActualMsg = TitleOnPage.Text;
        }

        internal void NotificationFunction()
        {
           
            //Select checkbox 
            CheckBox.Click() ;
            bool Checked = CheckBox.Selected;
            if (Checked)
            {
                GlobalDefinitions.VerifySuccessfulMessage("", "", "CheckBox-Notification");
            }

         
           
        /*    //Delete Selected
            DeleteSelected.Click();
            ExpectedMsg = "Notification updated";
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;
            GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg,ActualMsg, "DeleteSelected-Notification");

            //Mark Selected as Read
            Thread.Sleep(500);
            CheckBox.Click();
            Thread.Sleep(500);
            MarkSelectionAsRead.Click();
            ExpectedMsg = "Notification updated";
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;
            GlobalDefinitions.VerifySuccessfulMessage(ExpectedMsg, ActualMsg, "DeleteSelected-Notification");*/

            // Total number of rows
            Count = CheckBoxAll.Count;

            //Select All Icon and Verify
            SelectAll.Click();
            for (int i = 0; i < Count; i++)
            {
                Checked = CheckBoxAll[i].Selected;
                Thread.Sleep(500);
                if (!Checked)
                {
                    SelectedAll = false;
                }           

            }
            if (SelectedAll)
            {
                GlobalDefinitions.VerifySuccessfulMessage("", "", "SelectALL-Notification");
            }

            //Unselect All
            UnselectAll.Click();
            for (int i = 0; i < Count; i++)
            {
                Checked = CheckBoxAll[i].Selected;
                Thread.Sleep(500);
                if (Checked)
                {
                    UnselectedAll = false;
                }

            }
            if (UnselectedAll)
            {
                GlobalDefinitions.VerifySuccessfulMessage("", "", "UnSelectALL-Notification");
            }

        }

        internal void LoadMoreSeeLess()
        {
            Thread.Sleep(500);
            if (Action.Text.Contains("Load More..."))
            {
                Action.FindElement(By.XPath("//div[1]/center/a[@class='ui button']")).Click();
                Thread.Sleep(500);
                int CountMore = CheckBoxAll.Count;
                if (CountMore > Count)
                {
                    GlobalDefinitions.VerifySuccessfulMessage("", "", "Load More-Notification");
                }
            }else
            {
                if(Action.Text.Contains("...Show Less"))
                {
                    Action.FindElement(By.XPath("//div[2]/center/a[@class='ui button']")).Click();
                    Thread.Sleep(500);
                    int CountLess = CheckBoxAll.Count;
                    if (Count > CountLess)
                    {
                        GlobalDefinitions.VerifySuccessfulMessage("", "", "Show Less-Notification");
                    }

                }
                else
                {
                    GlobalDefinitions.VerifySuccessfulMessage("", "", "No Load More or Show less button");

                }
            }
           
            
        }


    }
}
