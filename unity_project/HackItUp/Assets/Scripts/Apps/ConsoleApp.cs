using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ConsoleApp : MonoBehaviour, IPointerClickHandler
{
    public Text consoleOutput;
    public InputField consoleInput;

    private void Awake()
    {
        consoleOutput = GetComponentInChildren<Text>();
        consoleInput = GetComponentInChildren<InputField>();

        consoleInput.onEndEdit.AddListener(ConsoleSubmitInput);
    }

    private void Start()
    {
        GiveFocus();
    }

    //Handles when user presses enter
    public void ConsoleSubmitInput(string input)
    {
        consoleInput.text = string.Empty;
        GiveFocus();
        Write(input);

    }

    //Writes to the console output
    public void Write(string output)
    {
        if (string.IsNullOrEmpty(output)) return;
        consoleOutput.text += "\n" + output;
    }

    //Gives focus to the console input field
    public void GiveFocus()
    {
        consoleInput.Select();
        consoleInput.ActivateInputField();
    }

    //Calls GiveFocus() whenever the console is clicked
    public void OnPointerClick(PointerEventData eventData)
    {
        GiveFocus();
    }
}
