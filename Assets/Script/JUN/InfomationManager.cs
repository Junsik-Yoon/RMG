using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfomationManager : MonoBehaviour
{
    private static InfomationManager _instance;
      public static InfomationManager instance
    {
        get
        {
            return _instance;
        }
    }
private void Awake() {
    _instance = this;
}
   public GameObject ui;
   public Text uiText;

   public void Notice(string text, int time)
   {
       ui.SetActive(true);
       uiText.text = text;

       Invoke("UnNotice",time);
   }
   public void UnNotice()
   {
       ui.SetActive(false);
   }
}
