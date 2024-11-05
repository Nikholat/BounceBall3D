using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject coinObject;
    [SerializeField] ParticleSystem particleSystems;
    [SerializeField] Sounds sounds;

    private bool isCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            coinObject.SetActive(false);
            particleSystems.Play();
            isCollected = true;
            sounds.PlayCoin();
            CoinСounter.coinCount += 1;
        }
    }
}
