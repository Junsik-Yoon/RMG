using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Encounter : MonoBehaviour
{
    BattleObjectData enemyData;
    public CameraManager cameraManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Monster")
        {
            enemyData =other.gameObject.GetComponent<MonsterEncounter>().enemyObjectData ;
            cameraManager.OnBattle();
            GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>().SetBattleUnits(enemyData, gameObject.GetComponent<Player>());
        }
    }
}
