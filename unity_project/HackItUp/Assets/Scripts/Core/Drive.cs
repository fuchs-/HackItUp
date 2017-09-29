
public enum DriveLetter { C, D, E, F, G, A, B }

public class Drive
{
    private FileSystem fileSystem;
    public DriveLetter letter;

    public Drive(FileSystem fs, DriveLetter l)
    {
        fileSystem = fs;
        letter = l;
    }

    public Drive(FileSystem fs) : this(fs, DriveLetter.C) { }
}
