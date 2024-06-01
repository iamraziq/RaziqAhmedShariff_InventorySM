using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnableForUI : MonoBehaviour
{
    public GameObject[] uis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool anyActive = false;

        foreach (GameObject ui in uis)
        {
            if (ui.activeInHierarchy)
            {
                anyActive = true;
                break; // No need to check further if any UI is active
            }
        }

        GetComponent<Volume>().enabled = anyActive;
    }

}
