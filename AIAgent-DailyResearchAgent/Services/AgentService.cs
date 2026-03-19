using AIAgent_DailyResearchAgent.Plugins;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel;

namespace AIAgent_DailyResearchAgent.Services
{
    public class AgentService
    {
        private readonly Kernel _kernel;

        public AgentService(AiKernelService kernelService)
        {
            _kernel = kernelService.Kernel;
            _kernel.ImportPluginFromType<ResearchPlugin>();
        }

        public async Task<string> RunAgent(string userGoal)
        {
            var chat = _kernel.GetRequiredService<IChatCompletionService>();

            var history = new ChatHistory();
            history.AddSystemMessage("You are an AI research agent.");
            history.AddUserMessage(userGoal);

            var result = await chat.GetChatMessageContentAsync(
                history
            );

#pragma warning disable CS8603 // Possible null reference return.
            return result.Content;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
