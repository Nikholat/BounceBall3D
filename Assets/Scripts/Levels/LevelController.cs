using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] ParticleSystem deathParticle;
    [SerializeField] GameObject playerObject;
    [SerializeField] GameObject Eyes;
    [SerializeField] Sounds sounds;
    private bool isDead = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            if (isDead)
            {
                playerObject.SetActive(false);
                Eyes.SetActive(false);
                deathParticle.Play();
                sounds.PlayDeath();
                StartCoroutine(RestartLevel());
            }
        }
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            UnlockLevel();
        }
    }

    private IEnumerator RestartLevel()
    {
        isDead = false;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isDead = true;
    }

    private void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel > PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }
}
