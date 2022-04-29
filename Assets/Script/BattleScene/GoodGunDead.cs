using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodGunDead : MonoBehaviour
{
    Monster goodGun;
    
    bool isBadGun=false;

    private void Awake()
    {
        goodGun = GetComponent<Monster>();
    }
    private void Update()
    {       
        DeadCheck();
    }
    private void DeadCheck()
    {
        if(goodGun.curHP <=0&& !isBadGun)
        {
            isBadGun = true;
            SceneManager.LoadScene("EndingScene");
                     
        }
    }
    
}


    

