using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    public Button btn1, btn2;

    void Start()
    {
        btn1.interactable = true;
        btn2.interactable = false;
    }
    void Lock_btn1()
    {
        btn1.interactable = false;
    }
    void UnLockk_btn2()
    {
        btn2.interactable = true;
    }
    public void StartLock_bnt1()
    {
        StartCoroutine("Lock_btn1");
    }
    public void StartUnLockk_btn2()
    {
        StartCoroutine("UnLockk_btn2");
    }
}
