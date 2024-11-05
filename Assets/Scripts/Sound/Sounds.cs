using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip blowUp;
    [SerializeField] AudioClip coin;
    [SerializeField] AudioClip interact;
    private AudioSource audioSource;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void JumpOn()
    {
        audioSource.PlayOneShot(jump);
    }

    public void PlayDeath()
    {
        audioSource.PlayOneShot(blowUp);
    }

    public void PlayCoin()
    {
        audioSource.PlayOneShot(coin);
    }

    public void PlayInteract()
    {
        audioSource.PlayOneShot(interact);
    }
}

