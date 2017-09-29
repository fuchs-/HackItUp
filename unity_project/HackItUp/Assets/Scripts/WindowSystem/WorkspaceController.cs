using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class WorkspaceController : MonoBehaviour, IPointerClickHandler
{
    event EventHandler OnWorkspaceClicked;

    public void AddOnWorkspaceClickedListener(EventHandler listener)
    {
        OnWorkspaceClicked += listener;
    }

    public void RemoveOnWorkspaceClickedListener(EventHandler listener)
    {
        OnWorkspaceClicked -= listener;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(OnWorkspaceClicked != null) OnWorkspaceClicked.Invoke(this, null);
    }
}
