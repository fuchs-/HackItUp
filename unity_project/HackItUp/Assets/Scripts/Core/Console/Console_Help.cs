using UnityEngine;

[CreateAssetMenu (menuName = "HackItUp/ConsolePrograms/help")]
public class Console_Help : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        foreach (ConsoleProgram program in engine.programs)
        {
            engine.app.Write(program.programName + " - " + program.programDescription);
        }

        engine.app.Write("\n");

        return true;        
    }
}
