using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameManager _manager;
    public List<GameObject> fingers = new List<GameObject>();
    private float time = 0.0f;
    public float interpolationPeriod = 3f;
    [SerializeField] private Animator controller;

    void Update () 
    {
        time += Time.deltaTime;
    
        if (time >= interpolationPeriod) {
            time = 0.0f;
            for(int i = 0; i < fingers.Count; i++)
            {
                controller = fingers[i].transform.GetChild(0).GetComponentInChildren<Animator>();
                controller.SetBool("Click", true);
            }
            
        }
    }
    public void BuyTool(TextMeshProUGUI price)
    {
        if(_manager.cookies >= int.Parse(price.text))
        {
            GameObject newFinger = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
            newFinger.transform.SetParent(gameObject.transform);
            Finger tool = newFinger.GetComponentInChildren<Finger>();
            tool.manager = _manager;

            fingers.Add(newFinger);
        }
    }
}