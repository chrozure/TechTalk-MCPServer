using ModelContextProtocol.Server;
using System.ComponentModel;

namespace TechTalk_MCPServer.Tools;

public class Tools
{
    [McpServerTool(Name = "makeNickname"), Description("Give someone a new nickname")]
    public static string GiveNickname([Description("The name of the person you want to give a nickname to")] string name)
    {
        // Can include other implementation
        // e.g. computation, sending requests, writing to databases, etc. 
        return $"Your new nickname is Nonchalant {name}.";
    }
}
