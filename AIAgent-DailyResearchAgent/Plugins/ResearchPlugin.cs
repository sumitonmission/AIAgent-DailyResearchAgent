using Microsoft.SemanticKernel;

namespace AIAgent_DailyResearchAgent.Plugins
{
    public class ResearchPlugin
    {
        [KernelFunction]
        public string GetResearchData(string topic)
        {
            // Fake for now (replace with API later)
            return $"Latest insights about {topic}: AI is growing fast.";
        }
    }
}
