using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState Instance { get; private set; }

    public float Score { get; private set; }
    public float TotalClicks { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}
