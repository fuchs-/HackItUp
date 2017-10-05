using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/ls")]
public class Console_LS : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        engine.app.Write(engine.CurrentFolder.listContents());

        return true;
    }
}
