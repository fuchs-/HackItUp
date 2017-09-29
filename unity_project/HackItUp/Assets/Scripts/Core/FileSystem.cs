
//A filesystem on a computer
public class FileSystem
{
    public Computer computer;
    public Drive mainDrive;

    public FileSystem(Computer c)
    {
        computer = c;

        mainDrive = new Drive(this);
    }
}
