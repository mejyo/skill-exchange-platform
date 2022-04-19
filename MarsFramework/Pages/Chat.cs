using static NUnit.Core.NUnitFramework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Chat Link
        [FindsBy(How = How.LinkText, Using = "Chat")]
        public IWebElement ChatLink { get; set; }

        //Click on Select User
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[1]/div/div[2]/div[2]/div[2]/div[1]")]
        public IWebElement SelectUser { get; set; }

        //Click on Message TextBox
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input")]
        public IWebElement SendMessageTextBox { get; set; }

        //Click on Send button
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/button[1]")]
        public IWebElement SendButton { get; set; }

        //Click on Search textbox 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[1]/div/div[1]/div/div[1]/input")]
        public IWebElement SearchTextBox { get; set; }

        //Click on Search Content
        [FindsBy(How = How.XPath, Using = "//div[@class='chatRoom']/div[@class='ui divided items']/div[@class='item']")]
        public IWebElement SearchContent { get; set; }


        //Click on Chat Room Page
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/h3")]
        public IWebElement ChatRoom { get; set; }

        public string ExpectedMsg;
        public string ActualMsg;


        internal void ChatFunction()
        {
            ChatLink.Click();
            SearchTextBox.SendKeys("Jyothi");
            SearchContent.Click();
            SendMessageTextBox.SendKeys("Hello");
            SendButton.Click();
            ExpectedMsg = "Chat Room";
            ActualMsg = ChatRoom.Text;
        }
              
    }
}
