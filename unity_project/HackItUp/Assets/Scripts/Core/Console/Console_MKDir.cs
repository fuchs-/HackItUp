using System;
using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/MKDir")]
public class Console_MKDir : ConsoleProgram
{
    public override bool Execute(ConsoleEngine engine, string[] args)
    {
        string dirName;

        if (args.GetLength(0) < 2)
        {
            engine.app.Write("Missing argument: directory name");

            return false;
        }

        dirName = args[1];

        if (engine.currentFolder.containsSubFolderWithName(dirName))
        {
            engine.app.Write("There's already a folder with this name here");

            return false;
        }

        engine.currentFolder.createSubFolderWithName(dirName);

        engine.app.Write("\n");

        return true;
    }
}
