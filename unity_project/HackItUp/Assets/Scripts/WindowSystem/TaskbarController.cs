using UnityEngine;

public class TaskbarController : MonoBehaviour
{
    public GameObject desktop;
    public GameObject startMenu;

    public void BtnStartMenuPressed()
    {
        startMenu.SetActive(!startMenu.activeSelf);
    }

    public void BtnConsolePressed()
    {
        if (!desktop.transform.FindChild("Console"))
        {
            GameObject app = Instantiate(Resources.Load<GameObject>("Apps/Console"), desktop.transform);
            app.name = "Console";
        }
        else
        {
            Debug.LogWarning("There can't be more than one console instances openned at one time");
        }
    }

    public void BtnClockPressed()
    {
        Debug.Log("Clock was Pressed");
    }
}
