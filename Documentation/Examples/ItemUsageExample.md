# Example Usage

Here's an example of how to use the item management system:

```csharp
using SCPSL_Framework.Managers;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ItemManager itemManager = new ItemManager();

        Weapon pistol = new Weapon("Pistol", 25, 50, new Dictionary<string, int> { {"damage", 25}, {"range", 50} });
        itemManager.AddItem(pistol);

        Tool medkit = new Tool("Medkit", "Healing", new Dictionary<string, int> { {"healing", 50} });
        itemManager.AddItem(medkit);

        MiscItem document = new MiscItem("Document", "Classified information", new Dictionary<string, int> { {"pages", 5} });
        itemManager.AddItem(document);

        itemManager.ListItems();
    }
}