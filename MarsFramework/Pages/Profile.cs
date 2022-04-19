using MarsFramework.Global;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using static NUnit.Core.NUnitFramework;


namespace MarsFramework
{
    public class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='1']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Hour Edit button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i")]
        private IWebElement HourEdit { get; set; }

        //Click on Hour dropdown
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement Hours { get; set; }

        //Click on Hour option
        [FindsBy(How = How.XPath, Using = "//option[@value='2']")]
        private IWebElement HourOpt { get; set; }

        //Click on Salary Edit button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")]
        private IWebElement SalaryEdit { get; set; }
                
        //Click on salary
        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement Salary { get; set; }

        //Click on Salary option
        [FindsBy(How = How.XPath, Using = "//option[@value='1']")]
        private IWebElement SalaryOpt { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "level")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//option[@value='Fluent']")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button")]
        private IWebElement AddLang { get; set; }
       
        
        //Edit the Language level
        [FindsBy(How = How.XPath, Using = "//option[@value='Basic']")]
        private IWebElement EditLangOpt { get; set; }

        //Click on Skill tab
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)")]
        private IWebElement SkillTab { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.Name, Using = "level")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//option[@value='Expert']")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button")]
        private IWebElement AddSkillButton { get; set; }
               
        //Edit the skill level option
        [FindsBy(How = How.XPath, Using = "//option[@value='Intermediate']")]
        private IWebElement EditSkilllevel { get; set; }

        //Click Education tab
        [FindsBy(How = How.XPath, Using = "//div[@class='ui top attached tabular menu']/a[@class ='item'][@data-tab='third']")]
        private IWebElement EducationTab { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.Name, Using = "instituteName")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.Name, Using = "country")]
        private IWebElement ChooseCountry { get; set; }

        //Choose country
        [FindsBy(How = How.XPath, Using = "//option[@value='New Zealand']")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Edit country
        [FindsBy(How = How.XPath, Using = "//option[@value='India']")]
        private IWebElement EditCountryOpt { get; set; }


        //Click on Title dropdown
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//option[@value='B.Sc']")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Edit title
        [FindsBy(How = How.XPath, Using = "//option[@value='B.A']")]
        private IWebElement EditTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.Name, Using = "degree")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//option[@value='2020']")]
        private IWebElement DegreeYearOpt { get; set; }

        //Edit Year
        [FindsBy(How = How.XPath, Using = "//option[@value='2021']")]
        private IWebElement EditDegreeYearOpt { get; set; }

        //Click on Add for Education
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']/input[@type='button'][@value='Add']")]
        private IWebElement AddEdu { get; set; }

        //Click Certification tab
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']/div[@class='ui top attached tabular menu']/a[@data-tab='fourth']")]
        private IWebElement CertificationTab { get; set; }


        //Add new Certificate
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//option[@value='2019']")]
        private IWebElement CertiYearOpt { get; set; }

        //Edit Opt from Year
        [FindsBy(How = How.XPath, Using = "//option[@value='2021']")]
        private IWebElement EditCertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//div[@class='five wide field']/input[@value='Add']")]
        private IWebElement AddCerti { get; set; }

        //Click on Edit Icon
        [FindsBy(How = How.XPath, Using = "//td[@class='right aligned']/span[@class='button']/i[@class='outline write icon']")]
        private IWebElement EditIcon { get; set; }

        // Delete button Icon
        [FindsBy(How = How.XPath, Using = "//span[@class='button']/i[@class='remove icon']")]
        private IWebElement DeleteIcon { get; set; }

        //Click on Update Button
        [FindsBy(How = How.XPath, Using = "//input[@type='button'][@value='Update']")]
        private IWebElement UpdateButton { get; set; }

        //Click on User Name
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span")]
        private IWebElement UserName { get; set; }

        //Click on User Name
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span > div > a:nth-child(2)")]
        private IWebElement ChangePasswordOption { get; set; }

        //Click on Current password
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/input[@name= 'oldPassword']")]
        private IWebElement CurrentPasswordTextBox { get; set; }

        //Click on New password textbox
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/input[@name= 'newPassword']")]
        private IWebElement NewPasswordTextBox { get; set; }

        //Click on Confirm password textbox
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/input[@name= 'confirmPassword']")]
        private IWebElement ConfirmPasswordTextBox { get; set; }

        //Click on Save
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/button[@type= 'button']")]
        private IWebElement SaveButton { get; set; }

        //Click on Edit Icon for Description
        [FindsBy(How = How.XPath, Using = "//h3[@class='ui dividing header']/span[@class='button']/i[@class='outline write icon']")]
        private IWebElement EditDescriptionIcon { get; set; }

        //Add Description
        [FindsBy(How = How.Name, Using = "value")]
        private IWebElement EnterDescription { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement Save { get; set; }

        //Successful Message
        [FindsBy(How = How.ClassName, Using = "ns-box-inner")]
        private IWebElement Message { get; set; }
        public string ExpectedMsg;
        public string ActualMsg;
        string Data;
        

        #endregion

        //Select Availability time
        internal void AvailabiltyTime()
        {           
            ExpectedMsg = "Availability updated";
            AvailabilityTimeEdit.Click();
            AvailabilityTime.Click();
            AvailabilityTimeOpt.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;

            Thread.Sleep(1000);
            
        }
        //Select Hour
        internal void AvailabiltyHour()
        {
           
            HourEdit.Click();
            Hours.Click();
            HourOpt.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;

            Thread.Sleep(1000);
        }

        //Select Earn
        internal void AvailabiltyEarn()
        {
            SalaryEdit.Click();
            Salary.Click();
            SalaryOpt.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;

            Thread.Sleep(1000);
        }
        //Enter Description
        internal void Description()
        {
            ExpectedMsg = "Description has been saved successfully";
            EditDescriptionIcon.Click();
            Thread.Sleep(500);
            EnterDescription.Clear();
            EnterDescription.SendKeys("Hello!! I am QA Tester");
            string locator = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button";
            GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver,By.XPath(locator),10);
            Save.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;
            GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
            Thread.Sleep(1000);                      
        }


        //Add Language 
        internal void AddLanguage()
        {

            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");

            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
                ExpectedMsg = Data + " has been added to your languages";
                AddNewLangBtn.Click();
                AddLangText.SendKeys(Data);
                ChooseLang.Click();
                ChooseLangOpt.Click();
                AddLang.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }
        //Edit Language
        internal void EditLanguage()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(3, "Language");
                ExpectedMsg = Data + " has been updated to your languages";
                EditIcon.Click();
                GlobalDefinitions.wait(2);
                AddLangText.Clear();
                AddLangText.SendKeys(Data);
                ChooseLang.Click();
                EditLangOpt.Click();
                UpdateButton.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Delete Language
        internal void DeleteLanguage()
        { 
           
            try 
            {
                ExpectedMsg = Data + " has been deleted from your languages";
                DeleteIcon.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);                          
         
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }


        //Add Skill
        internal void AddSkill()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skill");

            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(2, "Skill");
                ExpectedMsg = Data + " has been added to your skills";
                SkillTab.Click();
                Thread.Sleep(1000);
                AddNewSkillBtn.Click();
                AddSkillText.SendKeys(Data);
                ChooseSkill.Click();
                ChooseSkilllevel.Click();
                AddSkillButton.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        internal void EditSkill()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skill");

            //Edit editSkill
            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(3, "Skill");
                ExpectedMsg = Data + " has been updated to your skills";
                EditIcon.Click();
                GlobalDefinitions.wait(2);
                AddSkillText.Clear();
                AddSkillText.SendKeys(Data);
                ChooseSkill.Click();
                EditSkilllevel.Click();
                UpdateButton.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        internal void DeleteSkill()
        { 
             //Delete Skill
            try
            {
                ExpectedMsg = Data + " has been deleted";
                DeleteIcon.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);                

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }


        //add Education
        internal void AddEducation()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            try
            {
                ExpectedMsg = "Education has been added";
                EducationTab.Click();
                Thread.Sleep(1000);
                AddNewEducation.Click();
                Thread.Sleep(1000);
                EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
                ChooseCountry.Click();
                ChooseCountryOpt.Click();
                ChooseTitle.Click();
                ChooseTitleOpt.Click();
                Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
                DegreeYear.Click();
                DegreeYearOpt.Click();
                AddEdu.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Edit Education
        internal void EditEducation()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            try
            {
                ExpectedMsg = "Education as been updated";
                EditIcon.Click();
                EnterUniversity.Clear();
                EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "University"));
                ChooseCountry.Click();
                EditCountryOpt.Click();
                ChooseTitle.Click();
                EditTitleOpt.Click();
                Degree.Clear();
                Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Degree"));
                DegreeYear.Click();
                EditDegreeYearOpt.Click();
                UpdateButton.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Delete Education
        internal void DeleteEducation()
        { 
            try
            {
                ExpectedMsg = "Education entry successfully removed";
                DeleteIcon.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }


        }

        //Add certificate
        internal void AddCertification()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certifications");

            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(2, "Certificate");
                ExpectedMsg = Data + " has been added to your certification";
                CertificationTab.Click();
                Thread.Sleep(1000);
                AddNewCerti.Click();
                EnterCerti.SendKeys(Data);
                CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "From"));
                CertiYear.Click();
                CertiYearOpt.Click();
                AddCerti.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Edit certificate
        internal void EditCertification()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certifications");

            try
            {
                Data = GlobalDefinitions.ExcelLib.ReadData(3, "Certificate");
                ExpectedMsg = Data + " has been updated to your certification";
                EditIcon.Click();
                EnterCerti.Clear();
                EnterCerti.SendKeys(Data);
                CertiFrom.Clear();
                CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "From"));
                CertiYear.Click();
                EditCertiYearOpt.Click();
                UpdateButton.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Delete certificate
        internal void DeleteCertification()
        { 
            try
            {
                ExpectedMsg = Data + " has been deleted from your certification";
                DeleteIcon.Click();
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
                ActualMsg = Message.Text;
                GlobalDefinitions.WaitForElementToBeInvisible(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 10);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, e.Message, "Exception");
            }
        }

        //Change password
        internal void ChangePassword()
        {
            Thread.Sleep(2000); 
            GlobalDefinitions.WaitForElementClickable(GlobalDefinitions.driver, By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span"),10);
            UserName.Click();
            Thread.Sleep(500);
            ChangePasswordOption.Click();
            Thread.Sleep(500);
            CurrentPasswordTextBox.SendKeys("Industry");
            Thread.Sleep(500);
            NewPasswordTextBox.SendKeys("Industry1");
            Thread.Sleep(500);
            ConfirmPasswordTextBox.SendKeys("Industry1");
            Thread.Sleep(500);
            SaveButton.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.ClassName("ns-box-inner"), 5);
            ActualMsg = Message.Text;
            ExpectedMsg = "Password Changed Successfully";
        }


    }
}