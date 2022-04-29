using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSpot : MonoBehaviour
{
    public Conversation conversation;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().SetMaxHP();
            conversation.ReAction();
            StartCoroutine(EndConversation());
            
        }
    }
    IEnumerator EndConversation()
    {
        yield return new WaitForSeconds(1);
        conversation.ReAction();
    }
    
}
