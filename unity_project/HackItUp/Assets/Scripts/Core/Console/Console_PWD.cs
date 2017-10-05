using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/pwd")]
public class Console_PWD : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        engine.app.Write(engine.CurrentFolder.getAbsolutePathString() + "\n");

        return true;
    }
}
