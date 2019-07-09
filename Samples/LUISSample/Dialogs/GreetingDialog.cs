using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Threading.Tasks;

namespace LUISSample.Dialogs
{
    [Serializable]
    public class GreetingDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Hi, Welcome to the New BugReport Bot. How are you today?");
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            await context.PostAsync("How can I help you?");
            context.Done(result);
        }
    }
}