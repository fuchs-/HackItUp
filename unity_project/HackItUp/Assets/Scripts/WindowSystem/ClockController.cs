using System;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    Text date, time;

    private Color normal, hovered;

    void Awake()
    {
        date = gameObject.transform.GetChild(0).GetComponent<Text>();
        time = gameObject.transform.GetChild(1).GetComponent<Text>();
    }

    void Update()
    {
        DateTime current = DateTime.Now;

        date.text = current.Date.ToShortDateString();
        time.text = current.ToShortTimeString();
    }
}
