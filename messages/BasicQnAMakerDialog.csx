using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using Microsoft.Bot.Builder.Luis;

// For more information about this template visit http://aka.ms/azurebots-csharp-qnamaker
[Serializable]
[LuisModel("0b6dbd9b-01e2-42ef-8673-7d6718a40018", "4af017ad4ad84b46822b1f26bfd7d5a1")]
public class BasicQnAMakerDialog : LuisDialog<object>
{
    // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
    //public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("QnASubscriptionKey"), Utils.GetAppSetting("QnAKnowledgebaseId"))))
    //{
    //}
    
        [LuisIntent("Note.Create")]
        public async Task DefineOmar(IDialogContext context, LuisServiceResult result)
        {
           await context.PostAsync("Yakhi...Omar is an OP mystical creature lurking beneath the sands of modern Egypt.");
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("None")]
        public async Task NoIntent(IDialogContext context, LuisServiceResult result)
        {
            await context.PostAsync("Deomar you viraling...");
            context.Wait(MessageReceived);
        }
}