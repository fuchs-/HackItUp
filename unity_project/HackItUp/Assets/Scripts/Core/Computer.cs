
//This class represents a basic computer in the game
public class Computer
{
    public FileSystem fileSystem;

    public Computer()
    {
        fileSystem = new FileSystem(this);
    }
}
