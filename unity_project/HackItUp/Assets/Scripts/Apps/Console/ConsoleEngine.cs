using System.Collections.Generic;
using UnityEngine;

public class ConsoleEngine : MonoBehaviour
{
    public ConsoleApp app;

    public FileSystem fileSystem;

    private Folder currentFolder;
    public Folder CurrentFolder
    {
        get { return currentFolder; }
    }

    private string cursor;

    public List<ConsoleProgram> programs; 

    private void Awake()
    {
        app = GetComponent<ConsoleApp>();

        GameObject lh = GameObject.FindGameObjectWithTag("localhost");
        fileSystem = lh.GetComponent<Computer>().fileSystem;

        currentFolder = fileSystem.mainDrive.root;
        UpdateCursor();

        programs.Sort((x, y) => string.Compare(x.programName, y.programName));
    }

    private void OnDestroy()
    {
        app = null;
        fileSystem = null;
    }

    public void SubmitCommandLine(string line)
    {
        string output = cursor + line;

        if (string.IsNullOrEmpty(line)) return;

        app.Write(output);

        char[] s = {' '};
        string[] args = line.Split(s);

        args[0] = args[0].ToLower();

        foreach (ConsoleProgram program in programs)
        {
            if (args[0] == program.programName) program.Execute(this, args);
            else if (program.aliases != null)
            {
                for (int i = 0; i < program.aliases.Length; i++)
                {
                    if (args[0] == program.aliases[i])
                    {
                        program.Execute(this, args);
                        break;
                    }
                }
            }
        }
    }

    public void Write(string output)
    {
        app.Write(output);
    }

    public void ChangeCurrentFolder(Folder f)
    {
        currentFolder = f;
        UpdateCursor();
    }

    public void UpdateCursor()
    {
        cursor = currentFolder.getAbsolutePathString() + "> ";
    }
}
