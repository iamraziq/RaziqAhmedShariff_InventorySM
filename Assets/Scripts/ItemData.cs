//// ItemData.cs
//[System.Serializable]
//public class ItemData
//{
//    public int itemID;
//    public string itemName;
//    public ItemType itemType;

//    public ItemData(int id, string name, ItemType type)
//    {
//        itemID = id;
//        itemName = name;
//        itemType = type;
//    }
//}

using UnityEngine;

[System.Serializable]
public class ItemData
{
    public int itemID;
    public string itemName;
    public ItemType itemType;
    public Sprite itemSprite;  // Add this line to include a sprite reference

    public ItemData(int id, string name, ItemType type, Sprite sprite)
    {
        itemID = id;
        itemName = name;
        itemType = type;
        itemSprite = sprite;  // Initialize the sprite reference
    }
}

