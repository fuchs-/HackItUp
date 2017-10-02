using System.Collections;
using System.Collections.Generic;

public class Folder
{
    public Drive drive;

    public string name;
    public bool isRoot = false;

    public Folder parentFolder;
    public List<Folder> subFolders;

    public Folder(string name, Folder parent)
    {
        this.name = name;
        this.parentFolder = parent;

        this.drive = parent.drive;

        subFolders = new List<Folder>();
    }

    public Folder(string name, Drive drive)
    {
        this.drive = drive;
        this.name = name;

        subFolders = new List<Folder>();
    }

    public Folder(Drive drive) : this("New Folder", drive) { }

    public static Folder GetNewRootFolder(Drive drive)
    {
        Folder f = new Folder("root", drive);
        f.isRoot = true;

        f.parentFolder = null;

        return f;
    }
}
