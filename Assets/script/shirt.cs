using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject shirt;

    public void ShowAndHide()
    {
        if (shirt.activeSelf) shirt.SetActive(false);
        else shirt.SetActive(true);
    }
}
