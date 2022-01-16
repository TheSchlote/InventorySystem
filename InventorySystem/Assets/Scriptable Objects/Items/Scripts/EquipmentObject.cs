using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public int atkBonus;
    public int defenceBonus;
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
