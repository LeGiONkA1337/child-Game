using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Lock2 : MonoBehaviour
{
    public Button btn;
    
    void Lock_btn()
    {
        btn.interactable = false;
    }
    
    public void StartLock_bnt()
    {
        StartCoroutine("Lock_btn");
    }   
}
