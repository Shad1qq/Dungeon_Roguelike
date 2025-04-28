using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InventoryManager))]
public class CreateObjectScript: Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Create Item Object"))
        {
            GameObject.Instantiate(Resources.Load("Item"));
        }
    }
}