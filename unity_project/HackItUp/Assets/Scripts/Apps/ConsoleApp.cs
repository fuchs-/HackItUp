using UnityEngine;
using UnityEngine.UI;

public class ConsoleApp : AppController
{
    private void Awake()
    {
        base.Initialize();
        base.ChangeAppName("Console");
    }
}
