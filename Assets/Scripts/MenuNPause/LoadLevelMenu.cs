using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelMenu : MonoBehaviour
{
    private int levelUnlock;
    [SerializeField] Button[] buttons;

    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < Mathf.Min(levelUnlock, buttons.Length); i++)
        {
            buttons[i].interactable = true;
        }

        if (levelUnlock == 4)
        {
            PlayerPrefs.DeleteAll();
            levelUnlock = 1;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
            for (int i = 0; i < Mathf.Min(levelUnlock, buttons.Length); i++)
            {
                buttons[i].interactable = true;
            }
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
