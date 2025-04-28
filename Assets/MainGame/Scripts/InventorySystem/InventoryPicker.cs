using UnityEngine;

public class InventoryPicker : MonoBehaviour
{
    [SerializeField]private float _radius;
    [SerializeField]private float _alphaChannel;
    
    private InventoryManager _inventoryManager;

    private void Start()
    {
        _inventoryManager = GetComponent<InventoryManager>();
    }
    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius, 1<<7);
        if(colliders.Length > 0)
        {
            foreach (Collider collider in colliders) 
            {             
                collider.transform.position = Vector3.MoveTowards(collider.transform.position, transform.position, 2f);
            }
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, _alphaChannel);
        Gizmos.DrawSphere(transform.position, _radius);
    }

}
