using UnityEngine;


[CreateAssetMenu(menuName="RPG Setup/Item Data/Martial item",fileName="Material Data - ")]

public class ItemDataSO : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public ItemType itemType;
    public int maxStackSize = 2;
}
