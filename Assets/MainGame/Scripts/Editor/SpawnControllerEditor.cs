using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpawnRooms))]
public class SpawnControllerEditor : Editor
{
    private SpawnRooms _rooms;
    public override void OnInspectorGUI()
    {
        _rooms = (SpawnRooms)target;
        base.OnInspectorGUI();
        if(GUILayout.Button("Respawn Rooms"))
        {
            _rooms.SpawnRoom();
        }
    }
}
