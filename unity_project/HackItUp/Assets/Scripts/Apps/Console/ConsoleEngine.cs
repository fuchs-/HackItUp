using UnityEngine;

public class ConsoleEngine : MonoBehaviour
{
    private ConsoleApp app;

    private void Awake()
    {
        app = GetComponent<ConsoleApp>();
    }

    private void OnDestroy()
    {
        app = null;
    }

    public void SubmitCommandLine(string line)
    {
        if (string.IsNullOrEmpty(line)) return;

        if (line == "exit") app.appController.Close();
        app.Write(line);
    }
}
