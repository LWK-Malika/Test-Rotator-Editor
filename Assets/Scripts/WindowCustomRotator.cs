using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using com.technical.test;
using UnityEngine.UIElements;


public class WindowCustomRotator : EditorWindow
{


    [MenuItem("Window/Custom/Rotators Multiple Setter")]
    public static void ShowWindow()
    {
        GetWindow<WindowCustomRotator>("Rotators Multiple Setter");
    }

    [CustomEditor(typeof(Rotator))]
    void OnGUI()
    {
        Rotate();

        EditorGUILayout.Separator();

  

    }
    
    void Rotate()
    {

        int id = Selection.activeInstanceID;
        id = EditorGUILayout.IntField("Identifier int", id);

        var selected = Selection.instanceIDs;
        string select = selected.ToString();
        select = EditorGUILayout.TextField("Identifier name", select);

        int time = 5;
        time = EditorGUILayout.IntField("Time Before Stopping", time);

        bool reverse = false;
        reverse = EditorGUILayout.Toggle("Reverse Rotation", reverse);


        bool folder = true;
        EditorGUILayout.BeginFoldoutHeaderGroup(folder, "Rotator Settings");

        EditorGUI.indentLevel++;

        var selected2 = Selection.activeObject;
        string select2 = selected2.ToString();
        select2 = EditorGUILayout.TextField("Object To Rotate ", select2);

        Vector3 vec3 = new Vector3(1.0f, 1.0f, 1.0f);

        EditorGUILayout.Vector3Field("Angle", vec3);

        int second = 10;
        second = EditorGUILayout.IntField("Time To Rotate In Seconds", second);



        EditorGUI.indentLevel--;
        EditorGUILayout.EndFoldoutHeaderGroup();

    }

}
