using UnityEngine;
public class Room :MonoBehaviour
{
    private SpawnRooms _spawnRoomScript;
    private void Update()
    {
        _spawnRoomScript = GetComponentInParent<SpawnRooms>();
        Collider[] collisions = Physics.OverlapBox(transform.position, GetComponent<Collider>().bounds.extents); //Может еще надо будет поделить на два
        if (collisions[0].gameObject.TryGetComponent<Room>(out Room room))
        {
            if(room.gameObject != gameObject) 
            {
                _spawnRoomScript.SpawnRoom(gameObject);
                Destroy(gameObject);
            }

        }           

    }
}