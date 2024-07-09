using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public GameObject attackAnimation;

}
