# Inventory System

## Overview

This Unity project implements a comprehensive inventory system inspired by Flux (Redux) for predictable state management. The system allows players to pick up items from the game environment and store them in a "backpack" (inventory). It provides an efficient and user-friendly way to manage items, with real-time UI updates and robust data handling.

## Features

- **Item Pickup Mechanism**: Players can interact with items in the game environment by pressing the "E" key to pick them up.
- **Data Structures for Items**: Items are represented with attributes such as item ID, name, type/category, and sprite, using a serializable `ItemData` class.
- **Inventory Management**: The `InventoryManager` class handles adding, removing, and listing items in the inventory. It utilizes `List` and `Dictionary` data structures for efficient item management.
- **UI Representation**: The inventory UI updates in real-time to display the contents of the backpack, using Unity's UI system.
- **State Management**: The system uses a state management pattern inspired by Flux, ensuring predictable state changes through actions and reducers.

## Scripts and Their Functions

### Item Script

Represents items with properties such as item ID, name, type/category, and item sprite.

### ItemData Class

Serializable class to store item data in the inventory, including item ID, name, type/category, and item sprite.

### InventoryManager Script

Manages the player's inventory. Key methods:

- `AddItem(item: ItemData)`: Adds an item to the inventory.
- `RemoveItem(itemID: int)`: Removes an item from the inventory based on its ID.
- `GetInventory(): List<ItemData>`: Retrieves the current contents of the inventory.

### PlayerInteraction Script

Handles player interactions to pick up items from the game environment. The player can press the "E" key when near an item to pick it up.

### InventoryUI Script

Manages the user interface representation of the inventory, updating in real-time as items are added or removed. Updates the UI based on the current inventory contents.

### SlotManager Script

Manages individual inventory slots and handles the removal of items from the inventory UI. Updates item ID in the slot and handles the remove button click event.

## How to Use

1. **Item Pickup**: Interact with items in the game environment to pick them up. Press the "E" key when near an item to add it to your inventory.
2. **Inventory Management**: Use the methods provided by the `InventoryManager` class to manage the inventory.
3. **UI Display**: The inventory UI updates automatically to display the contents of the backpack in real-time.
