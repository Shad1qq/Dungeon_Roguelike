using Assets.MainGame.Scripts.Movement;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private Item _item;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<InventoryManager>(out InventoryManager inventoryManager))
        {
            inventoryManager.ItemAdd(_item);
            inventoryManager.InitializeHotBars();
            Destroy(gameObject);
        }
    }
}
