using System.Collections.Generic;
using UnityEngine;

public class SpawnRooms : MonoBehaviour
{
    [SerializeField]private float _xSize;
    [SerializeField]private float _zSize;

    private List<GameObject> _rooms = new List<GameObject>();


    public void SpawnRoom()
    {
        foreach(Room room in GetComponentsInChildren<Room>())
        {
            Destroy(room.gameObject);
        }
        foreach (GameObject room in _rooms)
        {
            Vector3 pos = new Vector3(Random.Range(-60, _xSize) / 2, 0, Random.Range(-60, _zSize) / 2);
            GameObject.Instantiate(room, transform, false).transform.localPosition = pos;        
        }

    }
    public void SpawnRoom(GameObject room)
    {
        Vector3 pos = new Vector3(Random.Range(-60, _xSize) / 2, 0, Random.Range(-60, _zSize) / 2);
        GameObject.Instantiate(room, transform, false).transform.localPosition = pos;
    }
    private void Start()
    {
        foreach (GameObject rooms in Resources.LoadAll("Rooms"))
        {
            _rooms.Add(rooms);
        }
        Debug.Log("Rooms: " + _rooms.Count);
        SpawnRoom();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(_xSize, 0, _zSize));
    }
}