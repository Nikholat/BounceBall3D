using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Pause : MonoBehaviour
{
    [SerializeField] private Transform menu;
    [SerializeField] SoundMenu soundMenu;
    [SerializeField] private Rigidbody playerRigidbody;

    public bool isRPaused = false;

    public void PauseScreen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        menu.localPosition = new Vector2(-Screen.width, 0);
        menu.LeanMoveLocalX(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundMenu.WhooshPlay();
        playerRigidbody.isKinematic = true;
        isRPaused = true;
    }

    public void Play()
    {
        isRPaused = false;
        menu.LeanMoveLocalX(-Screen.width, 0.5f).setEaseOutExpo();
        soundMenu.WhooshPlay();
        playerRigidbody.isKinematic = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

}
