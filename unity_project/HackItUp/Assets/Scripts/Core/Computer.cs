using UnityEngine;

//This class represents a basic computer in the game
public class Computer : MonoBehaviour
{
    public FileSystem fileSystem;

    public void Awake()
    {
        fileSystem = new FileSystem(this);
    }

    public void OnDestroy()
    {
        fileSystem = null;
    }
}
