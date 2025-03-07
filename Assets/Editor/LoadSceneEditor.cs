using System.Collections;
using System.Collections.Generic;
using Settings;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LoadScene))]
public class LoadSceneEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        LoadScene loadScene = (LoadScene)target;

        // Dibujamos el enum
        loadScene.loadType = (LoadScene.LoadType)EditorGUILayout.EnumPopup("Load Type", loadScene.loadType);

        // Mostramos solo la variable necesaria según el tipo de carga
        if (loadScene.loadType == LoadScene.LoadType.ByInt)
        {
            loadScene.sceneIndex = EditorGUILayout.IntField("Scene Index", loadScene.sceneIndex);
        }
        else
        {
            loadScene.sceneName = EditorGUILayout.TextField("Scene Name", loadScene.sceneName);
        }

        // Guarda los cambios en la escena
        if (GUI.changed)
        {
            EditorUtility.SetDirty(loadScene);
        }
    }
    
    
    
}
