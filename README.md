# Game_ChestSystem
creation of a chest system in game like in the game clash royal

# Game_About
  Chest System uses which uses a similar system as Battle Royale to create chests. The Created chest Can be unlocked with time or Gems. In the locked state the Chest will show the Item Type,Item state,Item unlock Duration.
  In the Unlocking State(when the chest is unlocking without gems) we can see a Count down on it. Also we can unlock it with gems at any time.In the Unlocked State We Can collet the rewards in the Chest.There is a total of 4 slots and 4 types of chests in the game.
# Game Data
Model :
  * Scriptable object
  * ChestClosedImage
  * ChestOpenImage
  * chestType
  * Coins
  * Gems

View :
  * Chest Button
  * Status Text
  * Type Text
  * Time Text
    
Controller :
  * Connecting with model and view
  * State Machine for Chest

Chest Type:
  * Common
  * UnCommon
  * Rare
  * Legendary

Chest Status:
  * locked
  * unlocking
  * unlocked
  * Collected

Chest Pool Service :
  creating a pool of chest prefab to manage and reuse a finite set of objects.

Services : MonoSingleton Generic:
  * Player Services
  * UI services
  * Slot Service


# Images
![CreatingChests](https://github.com/hareeshp007/Game_ChestSystem/assets/46471092/1a7914cc-0b66-41a5-bc50-e3ed93618ec7)

![ChestTimer](https://github.com/hareeshp007/Game_ChestSystem/assets/46471092/be42b654-79e8-4121-9881-6e341a375c17)

![OpenedChest](https://github.com/hareeshp007/Game_ChestSystem/assets/46471092/a4ad9dfb-de10-4787-ac2d-f64341488b7d)
