using FirstPersonMobileTools.DynamicFirstPerson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameplay : MonoBehaviour
{
    public GameObject playerController;
    // Start is called before the first frame update
    //private void OnEnable()
    //{
    //    pauseGame();
    //}

    //private void OnDisable()
    //{
    //    continueGame();
    //}

    public void pauseGame()
    {
        //playerController.GetComponent<CameraLook>().enabled = false;
        //playerController.GetComponent<MovementController>().enabled = false;
        //playerController.GetComponent<nonMobileInput>().LockCursor = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void continueGame()
    {
        //playerController.GetComponent<CameraLook>().enabled = true;
        //playerController.GetComponent<MovementController>().enabled = true;
        //playerController.GetComponent<nonMobileInput>().LockCursor = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
