using UnityEngine;

public class CatapultController : MonoBehaviour
{
    [SerializeField] GameObject clue;
    [SerializeField] GameObject catapultTrigger;
    private ICatapult iCatapult;
    private InputsController inputsController;
    private WinController winController;
    private bool playerInTrigger = false;


    private void Awake()
    {
        iCatapult = GetComponent<ICatapult>();
        inputsController = GetComponent<InputsController>();
        winController = GameObject.FindFirstObjectByType<WinController>();
    }

    private void Update()
    {
        if (playerInTrigger && inputsController.IsEKeyPressed())
        {
            winController.IncrementWinCount();
            iCatapult.BreakCatapult();
            catapultTrigger.SetActive(false);
            clue.SetActive(false);
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
