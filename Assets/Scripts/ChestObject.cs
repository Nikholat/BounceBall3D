using UnityEngine;

public class ChestObject : MonoBehaviour, IChest
{
    [SerializeField] Animator animatorChest;
    [SerializeField] Animator animatorExit;

    private bool isOpen;
    public bool IsOpen => isOpen;
    
    public void OpenChest()
    {
        isOpen = true;
        animatorChest.SetBool("IsOpen", isOpen);
        animatorExit.SetBool("IsOpen", isOpen);
    }
   
}
