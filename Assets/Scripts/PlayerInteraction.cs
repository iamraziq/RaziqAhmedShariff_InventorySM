using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 100f; // Range within which the player can interact with items
    public LayerMask interactableLayer; // Layer for interactable objects
    public KeyCode interactKey = KeyCode.E; // Key to interact with items
    public Camera playerCamera; // Reference to the player's camera

    void Start()
    {
        playerCamera = Camera.main; // Assign the main camera to playerCamera
    }
    void Update()
    {
        CheckForInteractable();
    }

    void CheckForInteractable()
    {
        Ray ray = playerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactionRange, interactableLayer))
        {
            if (hit.collider != null)
            {
                Item item = hit.collider.GetComponent<Item>();
                if (item != null && Input.GetKeyDown(interactKey))
                {
                    InventoryManager.Instance.AddItem(item, hit.collider.gameObject);
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("No item hit");
                }
            }
            else
            {
                Debug.Log("No item hit here");
            }
        }
    }
}
