//using UnityEngine;

//public class Item : MonoBehaviour
//{
//    public string itemName;
//    public int itemID;
//    public ItemType itemType;

//    //void OnTriggerEnter(Collider other)
//    //{
//    //    if (other.CompareTag("Player"))
//    //    {
//    //        InventoryManager.Instance.AddItem(this);
//    //        Destroy(gameObject);
//    //    }
//    //}
//}

//public enum ItemType
//{
//    Ball,
//    Vehicle,
//    QuestItem,
//    Misc
//}

using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;
    public string itemName;
    public ItemType itemType;
    public Sprite itemSprite;  // Add this line to include a sprite reference
}

public enum ItemType
{
    Ball,
    Vehicle,
    QuestItem,
    Misc
}

