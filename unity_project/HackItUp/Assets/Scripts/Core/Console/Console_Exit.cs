using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/exit")]
public class Console_Exit : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        engine.app.appController.Close();
        return true;
    }
}
