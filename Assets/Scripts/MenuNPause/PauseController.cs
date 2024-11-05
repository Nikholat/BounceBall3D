using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private Pause pause;
    private InputsController inputsController;
   // private bool isPaused = false;

    private void Start() 
    {
        inputsController = GetComponent<InputsController>();
    }

    void Update()
    {
        if (inputsController.IsEcapeKeyPressed())
        {
            if (pause.isRPaused)
            {
                pause.Play();
                pause.isRPaused = false;
            }
            else
            {
                pause.PauseScreen();
                pause.isRPaused = true;
            }
        }
    }
}
