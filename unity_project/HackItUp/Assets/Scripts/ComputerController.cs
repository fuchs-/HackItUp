using UnityEngine;

//This class controlles the localhost in the game
public class ComputerController : MonoBehaviour
{
    Computer playerComputer;

    private void Awake()
    {
        playerComputer = GetComponent<Computer>();
    }

    private void OnDestroy()
    {
        playerComputer = null;
    }

    //Closes the game
    public void ShutDown()
    {
        Debug.Log("Closing the game");
        Application.Quit();
    }
}
