using LUISSample.Model;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Threading.Tasks;

/// <summary>
/// 
/// 
/// Model ID/App ID     : LUIS UI -> My Apps -> Manage -> Application Settings -> Application Information -> Application ID
/// Subscription Key    : LUIS UI -> My Apps -> Manage -> Application Settings -> Keys and Endpoints -> Authoring Key
/// 
/// Below are optional parameters:
/// 
/// Domain = westus.api.cognitive.microsoft.com
/// Staging = true
/// </summary>

namespace LUISSample.Dialogs
{
    [LuisModel("c81afffe-b23f-4ee3-91ff-afe01ea26eec", "260bb6b6ddde457aaf5295b405915dc3", domain: "westus.api.cognitive.microsoft.com", staging: true)]
    [Serializable]
    public class LUISDialog: LuisDialog<BugReport>
    {
        private readonly BuildFormDelegate<BugReport> NewBugReport;

        public LUISDialog(BuildFormDelegate<BugReport> newBugReport)
        {
            this.NewBugReport = newBugReport;
        }

        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry I don't know what you mean.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("GreetingIntent")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            context.Call(new GreetingDialog(), Callback);
        }

        private Task Callback(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(MessageReceived);
            return Task.CompletedTask;
        }

        [LuisIntent("NewBugReportIntent")]
        public async Task BugReport(IDialogContext context, LuisResult result)
        {
            var enrollmentForm = new FormDialog<BugReport>(new BugReport(), this.NewBugReport, FormOptions.PromptInStart);
            context.Call<BugReport> (enrollmentForm, Callback);
        }
    }
}