using System;
using UnityEngine;
using UnityEngine.EventSystems;


public class TaskbarController : MonoBehaviour, IPointerClickHandler
{
    public GameObject workspace;
    public GameObject startMenu;

    private void Awake()
    {
        workspace.GetComponent<WorkspaceController>().AddOnWorkspaceClickedListener(OnWorkspaceClicked);
    }

    private void OnDestroy()
    {
        workspace.GetComponent<WorkspaceController>().RemoveOnWorkspaceClickedListener(OnWorkspaceClicked);
    }

    public void OnWorkspaceClicked(object sender, EventArgs e)
    {
        HideStartMenu();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        HideStartMenu();
    }

    #region Start Menu

    public void BtnStartMenuPressed()
    {
        startMenu.SetActive(!startMenu.activeSelf);
    }

    private void HideStartMenu()
    {
        if (startMenu.activeSelf) startMenu.SetActive(false);
    }

    #endregion



    public void BtnConsolePressed()
    {
        HideStartMenu();

        if (!workspace.transform.FindChild("Console"))
        {
            GameObject app = Instantiate(Resources.Load<GameObject>("Apps/Console"), workspace.transform);
            app.name = "Console";
        }
        else
        {
            Debug.LogWarning("There can't be more than one console instances openned at one time");
        }
    }

    public void BtnClockPressed()
    {
        HideStartMenu();
        Debug.Log("Clock was Pressed");
    }


}
