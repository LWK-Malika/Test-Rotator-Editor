using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.technical.test;
using UnityEditor;

[CustomEditor(typeof(Rotator))]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Rotator script = (Rotator)target;
        if(GUILayout.Button("Open Custom Window"))
        {
            EditorWindow.GetWindow<WindowCustomRotator>(false);
        }
    }

}
