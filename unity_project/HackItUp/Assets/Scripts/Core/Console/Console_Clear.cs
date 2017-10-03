using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/clear")]
public class Console_Clear : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        engine.app.consoleOutput.text = string.Empty;

        return true;
    }
}
