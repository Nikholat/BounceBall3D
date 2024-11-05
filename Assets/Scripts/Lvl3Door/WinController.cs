using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField] private Animator doorOpenAnim;
    private int winCount = 0;

    public void IncrementWinCount()
    {
        winCount++;
        Debug.Log("Win Count: " + winCount);
        if (winCount == 2)
        {
            DoorOpenAnim();
        }
    }

    public void DoorOpenAnim()
    {
        doorOpenAnim.SetBool("IsOpen", true);
    }
}
