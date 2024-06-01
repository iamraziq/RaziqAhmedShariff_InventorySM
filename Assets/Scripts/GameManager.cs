using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject backpackCanvas;
    public GameObject escapeCanvas;
    public PauseGameplay gameplay;
    // Start is called before the first frame update
    void Start()
    {
        //gameplay = FindAnyObjectByType<PauseGameplay>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        Invoke("disableGB", 0.1f);
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            escapeCanvas.SetActive(false);
            OnClickBag();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            backpackCanvas.SetActive(false);
            OnClickEscape();
        }
    }

    public void OnClickBag()
    {
        if (backpackCanvas.activeInHierarchy)
        {
            backpackCanvas.SetActive(false);
            gameplay.continueGame();
        }
        else if (!backpackCanvas.activeInHierarchy)
        {
            backpackCanvas.SetActive(true);
            gameplay.pauseGame();
        }
    }

    public void OnClickEscape()
    {
        if (escapeCanvas.activeInHierarchy)
        {
            escapeCanvas.SetActive(false);
            gameplay.continueGame();
        }
        else if (!escapeCanvas.activeInHierarchy)
        {
            escapeCanvas.SetActive(true);
            gameplay.pauseGame();
        }
    }
    public void disableGB()
    {
        backpackCanvas.SetActive(false);
    }

    public void OnClickQuitYes()
    {
        Application.Quit();
    }

    public void OnClickMenuYes()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void ONClickInfoOk()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
