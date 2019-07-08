using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormFlowSample.Models
{
    [Serializable]
    public class BugReport
    {
        public string Title;
        [Prompt("Enter a description for your report")]
        public string Description;
        [Prompt("What is your first name?")]
        public string FirstName;
        [Describe("Surname")]
        public string LastName;
        [Prompt("What is best date and time to callback?")]
        public DateTime? BestTimeofDayToCall;
        [Pattern(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")]
        public string PhoneNumber;
        public List<BugType> Bug;
        public Reproducability Reproduce;


        public static IForm<BugReport> BuildForm()
        {
            return new FormBuilder<BugReport>().
                Message("**Bug Details**").
                OnCompletion(onComplete).
                Build();
        }

        private static async Task onComplete(IDialogContext context, BugReport state)
        {
            context.PrivateConversationData.SetValue<bool>("ProfileComplete", true);
            await context.PostAsync("Thank you. Your Bug Report is complete.");
            context.Done(state);
        }
    }
}