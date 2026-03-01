using ModelContextProtocol.Server;
using System.ComponentModel;

namespace TechTalk_MCPServer.Prompts;

[McpServerPromptType]
public class Prompts
{
    [McpServerPrompt(Name = "make_nickname"), Description("Create a new nickname for someone")]
    public static string GiveNickname([Description("The name of the person you want to give a nickname to")] string name)
    {
        // Return the prompt that the user should use to ask the model
        return $"Can you give {name} a new nickname?";
    }
}
