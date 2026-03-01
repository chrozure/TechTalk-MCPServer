using ModelContextProtocol.Server;
using System.ComponentModel;

namespace TechTalk_MCPServer.Resources;

[McpServerResourceType]
public class Resources
{
    [McpServerResource(Name = "My secret"), Description("My very important secret")]
    public static string MySecret()
    {
        return "The cake is a lie.";
    }

    [McpServerResource(Name = "My number"), Description("A number")]
    public static string MyNumber()
    {
        // Resources do not need to return the same thing every time!
        var random = new Random();
        return random.Next(1, 100).ToString();
    }
}
