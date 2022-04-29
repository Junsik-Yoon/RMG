using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CollectItem : MonoBehaviour
{
    public InventoryItemData data;

    new public string name;

    protected void Collect()
    {
        QuestManager.instance.OnItemCollect(name);
        InventoryManager.instance.Add(data);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect();
        Destroy(gameObject);
    }
}
