
public class ConsoleEngine
{
    private ConsoleApp app;

    public ConsoleEngine(ConsoleApp app)
    {
        this.app = app;
    }

    public void SubmitCommandLine(string line)
    {
        if (line == "exit") app.appController.Close();
        app.Write(line);
    }
}
