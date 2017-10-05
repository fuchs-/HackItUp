using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/whoami")]
public class Console_whoami : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        Computer c = engine.fileSystem.computer;
        string info = c.computerName + "/" + c.username;

        engine.Write(info);
        engine.Write("\n");

        return true;
    }
}
