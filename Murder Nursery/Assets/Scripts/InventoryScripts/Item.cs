using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// stores info about items created & the items type (item tpye determines what use function it may have)
[CreateAssetMenu(fileName = "Item", menuName = "Item/Create Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;

    [TextArea]
    public string itemDescription;

    public Sprite icon;
    public ItemType itemType;

    // determines what the items use function will be
    public enum ItemType
    {
        Bribery,
        Key,
        QuestItem,
        Gift,
        MagnifyingGlass,
        PinBoard,
        Jotter,
        ListeningDevice,
            NoteBook
    }

}
