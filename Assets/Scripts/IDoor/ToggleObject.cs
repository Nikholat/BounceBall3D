using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private Sounds sounds;
    private bool isWork;
    public bool IsEnable => isWork;

    public void TurnOn()
    {
        isWork = true;
        animator.SetBool("IsWork", isWork);
        sounds.PlayInteract();
    }

    public void TurnOff()
    {
        isWork = false;
        animator.SetBool("IsWork", isWork);
        sounds.PlayInteract();
    }

}
