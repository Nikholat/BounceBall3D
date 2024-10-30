using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] GameObject clue;
    private IChest chest;
    private InputsController inputsController;
    private bool playerInTrigger = false;

    private void Awake()
    {
        chest = GetComponent<IChest>();
        inputsController = GetComponent<InputsController>();
    }
    
    private void Update()
    {
        if (playerInTrigger && inputsController.IsEKeyPressed())
        {
            chest.OpenChest();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
            clue.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        clue.SetActive(false);
        playerInTrigger = false;
    }
}
