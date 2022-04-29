using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSign : MonoBehaviour, IInterAction, IStoreAction
{
    public Conversation conversation;

    public bool ReAction()
    {
        return conversation.ReAction();
    }

    public bool Store()
    {
        return conversation.ReAction();
    }
}
