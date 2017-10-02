using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ConsoleApp : MonoBehaviour, IPointerClickHandler
{

    public AppController appController;

    Text consoleOutput;
    InputField consoleInput;

    private ConsoleEngine engine;

    private void Awake()
    {
        consoleOutput = GetComponentInChildren<Text>();
        consoleInput = GetComponentInChildren<InputField>();

        consoleInput.onEndEdit.AddListener(ConsoleSubmitInput);

        engine = GetComponent<ConsoleEngine>();
    }

    private void OnDestroy()
    {
        
        consoleInput.onEndEdit.RemoveListener(ConsoleSubmitInput);
        consoleOutput = null;
        consoleInput = null;

        engine = null;
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
        engine.SubmitCommandLine(input);
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
