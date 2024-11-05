using UnityEngine;

public class SoundMenu : MonoBehaviour
{
    [SerializeField] private AudioClip buttonSound;
    [SerializeField] private AudioClip whooshSound;
    private AudioSource audioSource;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void ButtonPlay()
    {
        audioSource.PlayOneShot(buttonSound);
    }

    public void WhooshPlay()
    {
        audioSource.PlayOneShot(whooshSound);
    }
}
