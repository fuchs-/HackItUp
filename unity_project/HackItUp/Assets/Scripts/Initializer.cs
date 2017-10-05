using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    private void Awake()
    {
        Folder.invalidNames = new List<string>();

        Folder.invalidNames.Add(".");
        Folder.invalidNames.Add("..");
    }

    private void OnDestroy()
    {
        Folder.invalidNames = null;
    }
}
