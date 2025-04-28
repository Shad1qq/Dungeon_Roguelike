using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private List<Item> _items = new List<Item>();
    [SerializeField] private List<HotbarCell> _hotbarCells = new List<HotbarCell>();
    [SerializeField]private GameObject _inventoryPanel;

    private InputSystem _inputSystem;

    public void ItemAdd(Item item)
    {
        if (item != null)
        {
            _items.Add(item);
        }
    }
    public void InitializeHotBars()
    {
        foreach (var item in _items)
        {    
            foreach (var hotbar in _hotbarCells)
            {
                if (item.ItemType.GetType() == hotbar.GetHotbarCellType().GetType())
                {
                    continue;
                }
                else
                {
                    if (!hotbar.IsFull)
                    {
                        hotbar.Initialize(item.Sprite);
                        return;
                    }
                }

                
            }   
            
        }
    }

    [Inject]
    private void Constructor(InputSystem inputSystem)
    {
        _inputSystem = inputSystem;
    }
    private void Start()
    {
        foreach(var hotbar in _inventoryPanel.GetComponentsInChildren<HotbarCell>())
        {
            _hotbarCells.Add(hotbar);
            Debug.Log("Succefuly initialized");
        }
        
        _inputSystem.Player.Interact.performed += OpenInventory;       
    }
    private void OpenInventory(InputAction.CallbackContext obj)
    {
        _inventoryPanel.SetActive(true);
    }


}
