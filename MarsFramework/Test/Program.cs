using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            [Test,Order(7)]
            public void ProfileTest()
            {
                  Profile profile = new Profile();
                  profile.AvailabiltyTime();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg,profile.ActualMsg, "Time Availability - Profile");
                  profile.AvailabiltyHour();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "Hour Availability - Profile");
                  profile.AvailabiltyEarn();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "Earn Availability - Profile");
                  profile.Description();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg,"Description - Profile");
                  profile.AddLanguage();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "AddLanguage - Profile");
                  profile.EditLanguage();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "EditLanguage - Profile");
                  profile.DeleteLanguage();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "DeleteLanguage - Profile");
                  profile.AddSkill();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "AddSkill - Profile");
                  profile.EditSkill();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "EditSkill - Profile");
                  profile.DeleteSkill();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "DeleteSkill - Profile");
                  profile.AddEducation();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "AddEducation - Profile");
                  profile.EditEducation();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "EditEducation - Profile");
                  profile.DeleteEducation();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "DeleteEducation - Profile");
                  profile.AddCertification();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "AddCertification - Profile");
                  profile.EditCertification();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "EditCertification - Profile");
                  profile.DeleteCertification();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "DeleteCertification - Profile");
                  profile.ChangePassword();
                  GlobalDefinitions.VerifySuccessfulMessage(profile.ExpectedMsg, profile.ActualMsg, "Change Password-Profile");

            }


            [Test,Order(2)]
                 public void ManageListingTest()
                 {
                     ManageListings manageListing = new ManageListings();
                     manageListing.Listing("add");
                     GlobalDefinitions.VerifySuccessfulMessage(manageListing.ExpectedMsg, manageListing.ActualMsg, "Add Skill- Manage Listngs");
                     manageListing.Listing("view");
                     GlobalDefinitions.VerifySuccessfulMessage(manageListing.ExpectedMsg, manageListing.ActualMsg, "View - Manage Listings");
                     manageListing.Listing("edit");
                     GlobalDefinitions.VerifySuccessfulMessage(manageListing.ExpectedMsg, manageListing.ActualMsg, "Edit - Manage Listings");
                     manageListing.Listing("delete");
                     GlobalDefinitions.VerifySuccessfulMessage(manageListing.ExpectedMsg, manageListing.ActualMsg, "Delete - Manage Listings");

                 }
            [Test,Order(1)]
                 public void ShareSkillTest()
                 {
                     //Add skill
                     ShareSkill shareSkillPage = new ShareSkill();
                     shareSkillPage.EnterShareSkill();
                     GlobalDefinitions.VerifySuccessfulMessage(shareSkillPage.ExpectedMsg, shareSkillPage.ActualMsg, "Add Skill- Skill Page");

                     //Mandatory Field is empty
                     shareSkillPage.EnterEmptyFieldShareSkill();
                     shareSkillPage.VerifyWarningMessage();
                
               
                 }
                
                

            [Test,Order(3)]
            public void ManageRequest()
             {
                 ManageRequest manageRequest = new ManageRequest();
                 manageRequest.GoToRecievedRequestsPage();
                 GlobalDefinitions.VerifySuccessfulMessage(manageRequest.ExpectedMsg,manageRequest.ActualMsg, "Request Page");
                 manageRequest.RecievedAction();
                 manageRequest.GoToSentRequests();
                 GlobalDefinitions.VerifySuccessfulMessage(manageRequest.ExpectedMsg, manageRequest.ActualMsg, "Sent Page");
                 manageRequest.SentAction();                

             }

            [Test, Order(4)]
            public void ChatTest()
            {
                Chat chat = new Chat();
                chat.ChatFunction();
                GlobalDefinitions.VerifySuccessfulMessage(chat.ExpectedMsg, chat.ActualMsg, "Chat Page");

            }
            [Test,Order(5)]
            public void NotificationTest()
            {
                Notification notification = new Notification();
                notification.GoToNotificationPage();
                GlobalDefinitions.VerifySuccessfulMessage(notification.ExpectedMsg, notification.ActualMsg, "Notification Page");
                notification.NotificationFunction();
            }


            [Test, Order(6)]
            public void SearchSkillTest()
            {
                SearchSkill searchSkill= new SearchSkill();
                searchSkill.SearchSkillFunction();
              
            }

        }
    }
}