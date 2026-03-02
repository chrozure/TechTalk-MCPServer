# Tech Talk - MCP Server

Small demo MCP server built with the C# SDK for my tech talk.

## Project layout

- `Program.cs` - Host setup + MCP registration (`tools`, `resources`, `prompts`)
- `Tools/Tools.cs` - Tool implementations
- `Prompts/Prompts.cs` - Prompt templates
- `Resources/Resources.cs` - Resource providers

## Tech stack

- .NET `9.0`
- `ModelContextProtocol` (`1.0.0`)
- `Microsoft.Extensions.Hosting` (`10.0.3`)

## Prerequisites

- .NET SDK 9.0+

# How to run locally

From the repository root:

```bash
dotnet build
```

Because this is an MCP stdio server, `dotnet run` is usually started by an MCP client rather than used directly in a terminal.

Once you have built the project, you will need to add an MCP server into the MCP client config file. For Claude Desktop, the file is `claude_desktop_config.json` and can be found in the developer settings.

```json
{
  "mcpServers": {
    "techtalk": {
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "C:\\ABSOLUTE\\PATH\\TO\\PROJECT",  <--- REPLACE THIS
        "--no-build"
      ]
    }
  }
}
```

Fully restart your client by ending it in the Task Manager and reopening it. You should be able to see it in the list of MCP servers. 

## How to use the MCP server
- Request prompt `make_nickname`: fill in the `name` field with `Harry` to retrieve the prompt
- Call tool `makeNickname`: ask the client "Can you give Harry a new nickname?"
- Read resources `My secret` and `My number`
