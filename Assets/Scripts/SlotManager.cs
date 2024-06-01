using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public int itemIdToDelete;

    public GameObject playerObject;
    public GameObject objectToTeleport;
    public float distanceFromCamera = 2f;
    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = FindObjectOfType<InventoryManager>();

        playerObject = GameObject.Find("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {
        itemIdToDelete = int.Parse(GetComponent<TMP_Text>().text);
    }

    public void OnClickRemove()
    {

        // Enable the associated GameObject
        if (inventoryManager.itemGameObjectMap.ContainsKey(itemIdToDelete))
        {
            GameObject itemGameObject = inventoryManager.itemGameObjectMap[itemIdToDelete];
            itemGameObject.SetActive(true);

            objectToTeleport = itemGameObject;
            Invoke("TeleportObjectInFrontOfCamera", 0f);
        }
        inventoryManager.RemoveItem(itemIdToDelete);
    }

    void TeleportObjectInFrontOfCamera()
    {
        // Make sure objectToTeleport and playerObject are not null
        if (objectToTeleport != null && playerObject != null)
        {
            // Get the position of the player and its forward direction
            Vector3 playerPosition = playerObject.transform.position;
            Vector3 playerForward = playerObject.transform.forward;

            // Calculate the position in front of the player
            Vector3 newPosition = playerPosition + playerForward * distanceFromCamera;
            // Add the Y-axis offset
            newPosition += Vector3.up * 2f;
            // Set the objectToTeleport's position to the calculated position
            objectToTeleport.transform.position = newPosition;
        }
        else
        {
            Debug.LogError("Object to teleport or player object is null!");
        }
    }
}
