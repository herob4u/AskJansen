using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace AskJansenLUIS
{
    [LuisModel("0b6dbd9b-01e2-42ef-8673-7d6718a40018", "e7920d7198c04145a22ad1efe3082433")]
    [Serializable]
    class LUISDialog : LuisDialog<object>
    {
        //public LUISDialog() : base (new LuisDialog<object>()) { }

        /// <summary>
        ///  Handles all generic definition inquiries.
        ///  i.e "What is ___?". Uses the Entity name as an object of inquiry.
        /// </summary>
        [LuisIntent("Define")]
        public async Task Define(IDialogContext context, LuisServiceResult result)
        {
            string message = string.Empty;
            result.Result.Query
            if(result.Result.Entities.Count == 0)
            {
                message = GetQnAResponse(result.Result.Query);
            }
            else
            {
                string query = "what is " + result.Result.CompositeEntities[0].Value;
                message = GetQnAResponse(query);
            }

            await context.PostAsync(message);

            context.Wait(MessageReceived);
        }


        [LuisIntent("Note.Create")]
        public async Task DefineOmar(IDialogContext context, LuisServiceResult result)
        {

            await context.PostAsync($"Yakhi...Omar is an OP mystical creature lurking beneath the sands of modern Egypt.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("")]
        public async Task UnknownIntent(IDialogContext context, LuisServiceResult result)
        {
            await context.PostAsync($"Deomar you viraling...");
            //context.Wait(MessageReceived);
        }

        private string GetQnAResponse(string query) { return null; }
    }

}
