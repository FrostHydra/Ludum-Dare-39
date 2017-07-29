using UnityEngine;

#if UNITY_EDITOR

using UnityEditor;

public class CreateButtonScriptableObject {

	[MenuItem("Scriptable Objects/Button")]
    static void ButtonSO()
    {
        ButtonLayout button = new ButtonLayout();

        string path = "Assets/ScriptableObjects/button.asset";
        path = AssetDatabase.GenerateUniqueAssetPath(path);
        AssetDatabase.CreateAsset(button, path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = button;
    }
}


#endif