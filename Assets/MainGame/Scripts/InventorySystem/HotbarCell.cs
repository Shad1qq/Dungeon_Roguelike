using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public enum HotbarCellType{
    Default,
    Weapon,
    Shield
}

public class HotbarCell : MonoBehaviour
{
    public bool IsFull { get; private set; }
    public HotbarCellType GetHotbarCellType() => _type;
    [SerializeField] private HotbarCellType _type;
    private Image _image;
   
    public void Initialize(Sprite sprite)
    {  
        _image.sprite = sprite;
        IsFull = true;
    }
    private void Start()
    {
        _image = GetComponent<Image>();
    }
}
