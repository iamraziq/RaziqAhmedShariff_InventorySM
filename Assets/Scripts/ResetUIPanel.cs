using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetUIPanel : MonoBehaviour
{
    public GameObject[] panels;

    private void OnEnable()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
    }
}
