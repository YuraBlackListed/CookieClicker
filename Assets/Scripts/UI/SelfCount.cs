using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelfCount : MonoBehaviour
{
    private TextMeshProUGUI TextMeshProObject;
    [SerializeField] private GameManager manager;
    int prevCount = 1;
    void Start()
    {
        TextMeshProObject = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        SetCount();
    }
    public void SetCount()
    {
        if(prevCount != manager.cookies)
        {
            int count = manager.cookies;
            if(count == 1)
            {
                TextMeshProObject.text = count.ToString() + " cookie";
            }
            else
            {
                TextMeshProObject.text = count.ToString() + " cookies";
            }
            prevCount = count;
        }
    }
}
