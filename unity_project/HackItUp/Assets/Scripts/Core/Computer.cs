using UnityEngine;

public enum ComputerKind { Desktop, Laptop }

//This class represents a basic computer in the game
public class Computer : MonoBehaviour
{
    public FileSystem fileSystem;
    public ComputerKind kind;
    public string computerName;
    public string username;

    public void Awake()
    {
        fileSystem = new FileSystem(this);
    }

    public void OnDestroy()
    {
        fileSystem = null;
        computerName = null;
        username = null;
    }

    public void setRandomComputerKind()
    {
        int i = Random.Range(1, 100);

        if (i <= 50) kind = ComputerKind.Desktop;
        else kind = ComputerKind.Laptop;
    }

    public void setName()
    {
        computerName = ComputerNameGenerator.Instance.getName(kind);
    }
}
