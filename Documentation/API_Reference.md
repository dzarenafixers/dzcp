# API Reference

## GameEngine

- `void Start()`: Starts the game engine.

## EventManager

- `void TriggerEvent(string eventName)`: Triggers an event.

## CharacterManager

- `void AddCharacter(string character)`: Adds a character.
- `void ListCharacters()`: Lists all characters.

## ItemManager

- `void AddItem(string item)`: Adds an item.
- `void ListItems()`: Lists all items.

## gameRole

- `void ExecuteRole()`: Executes the logic for the game role.
# API Reference

## Event

- `string EventName`: The name of the event.
- `void Trigger()`: Method to trigger the event.

## EventManager

- `void RegisterEvent(Event gameEvent)`: Registers a new event.
- `void TriggerEvent(string eventName)`: Triggers an event by name.

## PlayerJoinedEvent

- `string PlayerName`: The name of the player who joined.
- `void Trigger()`: Triggers the player joined event.

## PlayerLeftEvent

- `string PlayerName`: The name of the player who left.
- `void Trigger()`: Triggers the player left event.