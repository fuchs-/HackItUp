
public enum DriveLetter { C, D, E, F, G, A, B }

public class Drive
{
    public FileSystem fileSystem;
    public DriveLetter letter;

    public Folder root;

    public Drive(FileSystem fs, DriveLetter l)
    {
        fileSystem = fs;
        letter = l;

        root = Folder.GetNewRootFolder(this);
    }

    public Drive(FileSystem fs) : this(fs, DriveLetter.C) { }
}
