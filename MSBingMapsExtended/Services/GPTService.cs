using Azure;
using Azure.AI.OpenAI;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using static System.Environment;

namespace MSBingMapsExtended.Services
{
    public class GPTService
    {
        private string Key;

        private string Endpoint;

        private OpenAIClient Client;

        public GPTService()
        {
            Endpoint = GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
            Key = GetEnvironmentVariable("AZURE_OPENAI_KEY");
            Client = new OpenAIClient(new Uri(Endpoint), new AzureKeyCredential(Key));
        }

        public string[] AskGPT(string prompt, Tuple<ChatRole, string>[] context = null, string systemInstructions = null)
        {
            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                Messages = { },
                MaxTokens = 1000
            };

            if (!string.IsNullOrEmpty(systemInstructions))
                chatCompletionsOptions.Messages.Add(new ChatMessage(ChatRole.System, systemInstructions));

            if (context != null)
                foreach (var pair in context)
                    chatCompletionsOptions.Messages.Add(new ChatMessage(pair.Item1, pair.Item2));

            chatCompletionsOptions.Messages.Add(new ChatMessage(ChatRole.User, prompt));

            Response<ChatCompletions> response = Client.GetChatCompletions(
                                        deploymentOrModelName: "gpt-35-turbo-16k",
                                        chatCompletionsOptions);

            string strResult = response.Value.Choices[0].Message.Content;

            if (string.IsNullOrEmpty(strResult))
                return new string[0];

            return strResult.Replace("**", "").Split("\n").Where(s => !string.IsNullOrEmpty(s)).ToArray();
        }
    }
}
