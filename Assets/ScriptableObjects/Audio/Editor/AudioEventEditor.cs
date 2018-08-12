using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AudioEvent), true)]
public class AudioEventEditor : Editor {
    [SerializeField]
    private AudioSource source;

    private void OnEnable()
    {
        source = EditorUtility.CreateGameObjectWithHideFlags("Audio Preview", HideFlags.HideAndDontSave, typeof(AudioSource))
                                .GetComponent<AudioSource>();
    }
    private void OnDisable()
    {
        DestroyImmediate(source.gameObject);
    }
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUI.BeginDisabledGroup(serializedObject.isEditingMultipleObjects);

        if(GUILayout.Button("Preview"))
        {
            ((AudioEvent)target).Play(source);
        }
        EditorGUI.EndDisabledGroup();
    }
}
