using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        if (UnityEditor.EditorApplication.timeSinceStartup < 30)
        {
            Debug.Log("Editor Startup!");
        }
    }
}
