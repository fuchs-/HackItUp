using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDropHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isDragging;
    Vector3 lastPosition;

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
