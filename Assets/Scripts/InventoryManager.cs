//// InventoryManager.cs
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.UI;
////using UnityEngine.UIElements;

//public class InventoryManager : MonoBehaviour
//{
//    public static InventoryManager Instance;

//    private List<ItemData> inventory = new List<ItemData>();

//    public Button removeItemButton;
//    void Awake()
//    {
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }


//    }

//    private void Update()
//    {
//        // Ensure the button is linked either through Inspector or by finding it
//        if (removeItemButton == null)
//        {
//            removeItemButton = GameObject.Find("itemSlotPrefab(Clone)").GetComponentInChildren<Button>();
//        }

//        // Add listener to the button
//        removeItemButton.onClick.AddListener(() => RemoveItem(1)); // Example with itemID 1
//    }
//    public void AddItem(Item item)
//    {
//        var newItem = new ItemData(item.itemID, item.itemName, item.itemType);
//        inventory.Add(newItem);
//        InventoryUI.Instance.UpdateInventoryUI(inventory);
//    }

//    public void RemoveItem(int itemID)
//    {
//        inventory.RemoveAll(item => item.itemID == itemID);
//        InventoryUI.Instance.UpdateInventoryUI(inventory);
//    }

//    public List<ItemData> GetInventory()
//    {
//        return inventory;
//    }
//}


using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    private List<ItemData> inventory = new List<ItemData>();

    public Dictionary<int, GameObject> itemGameObjectMap = new Dictionary<int, GameObject>();
   // private GameObject itemGameObject;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItem(Item item, GameObject itemGameObject)
    {
        var newItem = new ItemData(item.itemID, item.itemName, item.itemType, item.itemSprite);
        inventory.Add(newItem);
        itemGameObjectMap[item.itemID] = itemGameObject; // Store reference to the GameObject
        InventoryUI.Instance.UpdateInventoryUI(inventory);
    }

    public void RemoveItem(int itemID)
    {
        inventory.RemoveAll(item => item.itemID == itemID);
        InventoryUI.Instance.UpdateInventoryUI(inventory);
    }

    public List<ItemData> GetInventory()
    {
        return inventory;
    }
}

