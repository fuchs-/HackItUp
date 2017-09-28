using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDropHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject go;
    bool isDragging = false;
    Vector3 mouse, delta;

    private void FixedUpdate()
    {
        if (isDragging)
        {
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse.z = 0;
            go.transform.position = mouse - delta;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        delta = Vector3.zero;
        delta.x = mouse.x - go.transform.position.x;
        delta.y = mouse.y - go.transform.position.y;

        isDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        delta = Vector3.zero;
        isDragging = false;
    }
}
