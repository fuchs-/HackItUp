using System.Collections;
using System.Collections.Generic;

public class Folder
{
    #region static

    //Initializer
    public static List<string> invalidNames;

    #endregion

    #region Properties

    public Drive drive;

    public string folderName;
    public bool isRoot = false;

    public Folder parentFolder;
    public List<Folder> subFolders;
    public List<File> files;

    #endregion

    #region Static Methods

    public static Folder GetNewRootFolder(Drive drive)
    {
        Folder f = new Folder("root", drive);
        f.isRoot = true;

        f.parentFolder = null;

        return f;
    }

    #endregion

    #region Constructors

    public Folder(string name, Folder parent) : this(name, parent.drive)
    {
        this.parentFolder = parent;
    }

    public Folder(string name, Drive drive)
    {
        this.drive = drive;
        this.folderName = name;

        subFolders = new List<Folder>();
        files = new List<File>();
    }

    public Folder(Drive drive) : this("New Folder", drive) { }

    #endregion

    #region Methods

    public string getAbsolutePathString()
    {
        string ret = "";
        Folder current = this;

        while (!current.isRoot)
        {
            ret = "/" + current.folderName + ret;
            current = current.parentFolder;
        }

        ret = this.drive.letter.ToString() + ":" + ret;


        return ret;
    }

    public bool containsSubFolderWithName(string name)
    {
        foreach (Folder f in subFolders)
        {
            if (f.folderName == name) return true;
        }

        return false;
    }

    public Folder createSubFolderWithName(string name)
    {
        Folder ret;

        ret = new Folder(name, this);
        subFolders.Add(ret);

        return ret;
    }

    //returns null if there's no subfolder with the provided name
    public Folder getSubFolderWithName(string name)
    {
        Folder ret = null;

        foreach (Folder f in subFolders)
        {
            if (f.folderName == name) ret = f;
        }

        return ret;
    }

    public string listContents()
    {
        string ret = string.Empty;

        foreach (Folder f in subFolders)
        {
            ret += f.folderName + "/\n";
        }

        foreach (File f in files)
        {
            ret += f.fileName + "\n";
        }

        return ret;
    }

    #endregion
}
