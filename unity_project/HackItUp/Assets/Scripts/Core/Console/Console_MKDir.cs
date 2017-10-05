using System;
using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/MKDir")]
public class Console_MKDir : ConsoleProgram
{
    public override bool Execute(ConsoleEngine console, string[] args)
    {
        string dirName;

        if (args.GetLength(0) < 2)
        {
            console.app.Write("Missing argument: directory name");

            return false;
        }

        dirName = args[1];

        if (console.CurrentFolder.containsSubFolderWithName(dirName))
        {
            console.Write("There's already a folder with this name here");
            return false;
        }

        foreach (string n in Folder.invalidNames)
        {
            if (dirName == n)
            {
                console.Write("Invalid directory name");
                return false;
            }
        }

        console.CurrentFolder.createSubFolderWithName(dirName);

        console.app.Write("\n");

        return true;
    }
}
