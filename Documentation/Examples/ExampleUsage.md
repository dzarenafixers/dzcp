# Example Usage

Here's an example of how to use the framework:

```csharp
using SCPSL_Framework.Core;
using SCPSL_Framework.Events;
using SCPSL_Framework.Managers;
using SCPSL_Framework.Utilities;
using SCPSL_Framework.GameRoles.Exiled;

class Program
{
    static void Main()
    {
        GameEngine engine = new GameEngine();
        engine.Start();

        EventManager eventManager = new EventManager();
        eventManager.TriggerEvent("GameStarted");

        CharacterManager characterManager = new CharacterManager();
        characterManager.AddCharacter("Player1");
        characterManager.ListCharacters();

        ItemManager itemManager = new ItemManager();
        itemManager.AddItem("Gun");
        itemManager.ListItems();

        ExiledRole exiledRole = new ExiledRole();
        exiledRole.ExecuteRole();

        Logger.Log("Game initialized successfully.");
    }
}