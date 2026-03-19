using Microsoft.SemanticKernel;

namespace AIAgent_DailyResearchAgent.Services
{
    public class AiKernelService
    {
        public Kernel? Kernel { get; }

        public AiKernelService(IConfiguration config)
        {
            var builder = Kernel.CreateBuilder();

            builder.AddOpenAIChatCompletion(
                modelId: config["OpenAI:Model"],
                apiKey: config["OpenAI:ApiKey"]
            );

            Kernel = builder.Build();
        }
    }
}
