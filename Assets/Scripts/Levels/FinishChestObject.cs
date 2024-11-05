using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishChestObject : MonoBehaviour, IChest
{
    private bool isOpen;
    public bool IsOpen => isOpen;
    
    public void OpenChest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
