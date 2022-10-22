using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour
{
    public GameManager manager;
    [SerializeField] private Animator controller;
    public void Click()
    {
        manager.ToolAddCookie();
        controller.SetBool("Click", false);
    }
}
