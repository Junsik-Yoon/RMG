using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        QuestManager.instance.OnItemCollect("Script");
        Destroy(gameObject);
    }
}
