using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinСounter : MonoBehaviour
{
    public static int coinCount;
    private Text coinText;

    private void Start() 
    {
        coinText = GetComponent<Text>();
        coinCount = 0;
    }

    private void Update() 
    {
        coinText.text = "" + coinCount;
    }
}
