using Assets.MainGame.Scripts.Movement;
using UnityEngine;
using System;
[CreateAssetMenu(fileName = "ItemObject", menuName = "InventorySystem/Create Item")]
public class Item:ScriptableObject
{
    public string Itemname;
    public string Description;
    public Sprite Sprite;
    public ItemTypes ItemType;
}
[Serializable]
public enum ItemTypes
{
    Default,
    Weapon,
    Shield,
    Artifact
}
