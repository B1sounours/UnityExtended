using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(LevelButton))]
public class LevelButtonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LevelButton script = (LevelButton)target;



        DrawDefaultInspector();

        if (GUILayout.Button("Invoke"))
        {
            script.Interact();
        }
    }
}
