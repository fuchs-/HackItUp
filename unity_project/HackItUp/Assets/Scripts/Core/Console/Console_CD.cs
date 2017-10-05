using System;
using UnityEngine;

[CreateAssetMenu(menuName = "HackItUp/ConsolePrograms/cd")]
public class Console_CD : ConsoleProgram
{
    public override bool Execute(ConsoleEngine console, string[] args)
    {
        if (args.GetLength(0) < 2)
        {
            console.Write("cd needs a folder name as a parameter");
            return false;
        }

        string name = args[1];

        //special cases
    
        if (name == ".") return true;
        if (name == "..")
        {
            if (console.CurrentFolder.isRoot)
            {
                console.Write("Folder's already root, can't go to parent folder");
                return false;
            }

            console.ChangeCurrentFolder(console.CurrentFolder.parentFolder);

            return true;
        }

        Folder f = console.CurrentFolder.getSubFolderWithName(name);

        if (f == null)
        {
            console.Write("There is no subfolder named '" + name + "'");
            return false;
        }
        else
        {
            console.ChangeCurrentFolder(f);
        }


        return true;
    }
}
