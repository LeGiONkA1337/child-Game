using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCosts : MonoBehaviour
{
    public GameObject SpreadOutBboard;

    public void ShowAndHide()
    {
        if (SpreadOutBboard.activeSelf) SpreadOutBboard.SetActive(false);
        else SpreadOutBboard.SetActive(true);
    }
}
