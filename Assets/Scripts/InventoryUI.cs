using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    public GameObject inventoryPanel;
    public GameObject itemSlotPrefab;
    public Transform itemSlotContainer;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateInventoryUI(List<ItemData> inventory)
    {
        foreach (Transform child in itemSlotContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (var itemData in inventory)
        {
            var slot = Instantiate(itemSlotPrefab, itemSlotContainer);
            slot.GetComponentInChildren<TMP_Text>().text = itemData.itemID.ToString();
            slot.GetComponentInChildren<Image>().sprite = itemData.itemSprite;
        }
    }
}
