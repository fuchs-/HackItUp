using UnityEngine;

public abstract class ConsoleProgram : ScriptableObject
{
    public string programName;
    public string programDescription;

    public string[] aliases;

    public abstract bool Execute(ConsoleEngine console, string[] args);

}
