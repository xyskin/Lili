using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(normalrotation))]
public class normalrotationEditor : Editor {
    SerializedProperty eulerang;

    void OnEnable()
    {
        eulerang = serializedObject.FindProperty("eulerang");
    }
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        var t = (target as normalrotation);
        EditorGUILayout.BeginVertical();
        if (GUILayout.Button("Test"))
        {
            t.set();
        }
        EditorGUILayout.PropertyField(eulerang);
        EditorGUILayout.EndVertical();
        serializedObject.ApplyModifiedProperties();
    }
}
