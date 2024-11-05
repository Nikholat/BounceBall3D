using UnityEngine;

public class CatapultObject : MonoBehaviour, ICatapult
{
    [SerializeField] Animator breakAnim;
    [SerializeField] Sounds sounds;
    private bool isWin;
    public bool IsWin => isWin;
    
    public void BreakCatapult()
    {
        isWin = true;
        breakAnim.SetBool("IsBreak", true);
        sounds.PlayInteract();
    }
}
