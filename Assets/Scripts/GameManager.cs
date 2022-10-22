using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int cookies = 1;
    public int profitPerClick = 1;
    [SerializeField] private ToolManager shop;
    [SerializeField] private ParticleSystem particles;
    public void AddCookie(int amount)
    {
        cookies+=amount;
        var main = particles.main;
        main.maxParticles = cookies;
    }
    public void RemoveCookies(TextMeshProUGUI price)
    {
        if(cookies >= int.Parse(price.text))
        {
            cookies -= int.Parse(price.text);
        }
    }
    public void AddProfit(TextMeshProUGUI price)
    {
        if(cookies >= int.Parse(price.text))
        {
            profitPerClick++;
        }
    }
    public void SpeedUp(TextMeshProUGUI price)
    {
        if(cookies >= int.Parse(price.text))
        {
            shop.interpolationPeriod-= 0.1f;
        }
    }
    public void ToolAddCookie()
    {
        cookies+=profitPerClick;
        var main = particles.main;
        main.maxParticles = cookies;
    }
}
