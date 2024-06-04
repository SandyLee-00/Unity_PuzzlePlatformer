using UnityEngine;

public enum EquippableItemType
{
    Speed,
    Jump
}

[CreateAssetMenu(fileName = "New EquippableItemData", menuName = "SOData/ItemData/EquippableItem")]
public class EquipableItemData : ItemData
{
    [Header("Equip Info")]
    public EquippableItemType type;
    public float increaseValue;
}