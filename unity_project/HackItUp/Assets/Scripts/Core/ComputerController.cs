using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class represents the player's computer in the game
public class ComputerController : MonoBehaviour
{
    //Closes the game
    public void ShutDown()
    {
        Debug.Log("Closing the game");
        Application.Quit();
    }
}
