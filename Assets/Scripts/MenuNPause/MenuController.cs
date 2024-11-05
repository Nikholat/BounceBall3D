using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private SoundMenu soundMenu;
    [SerializeField] private Transform menu;
    [SerializeField] private Transform levels;
    [SerializeField] private Transform rules;
    [SerializeField] private Transform author;

    private void Start() 
    {
       soundMenu = GetComponent<SoundMenu>(); 
    }

    public void OnEnableMenu() 
    {
        menu.localPosition = new Vector2 (-Screen.width, 0);
        menu.LeanMoveLocalX(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundMenu.ButtonPlay();
    }

    public void CloseMenu()
    {
        menu.LeanMoveLocalX(-Screen.width, 0.5f).setEaseOutExpo();
    }

    public void OnEnableLevels() 
    {
        levels.localPosition = new Vector2 (-Screen.width, 0);
        levels.LeanMoveLocalX(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundMenu.ButtonPlay();
    }

    public void CloseLevels()
    {
        levels.LeanMoveLocalX(-Screen.width, 0.5f).setEaseOutExpo();
    }

    public void OnEnableRules() 
    {
        rules.localPosition = new Vector2 (-Screen.width, 0);
        rules.LeanMoveLocalX(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundMenu.ButtonPlay();
    }

    public void CloseRules()
    {
        rules.LeanMoveLocalX(-Screen.width, 0.5f).setEaseOutExpo();
    }

    public void OnEnableAuthor() 
    {
        author.localPosition = new Vector2 (-Screen.width, 0);
        author.LeanMoveLocalX(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        soundMenu.ButtonPlay();
    }

    public void CloseAuthor()
    {
        author.LeanMoveLocalX(-Screen.width, 0.5f).setEaseOutExpo();
    }

}
