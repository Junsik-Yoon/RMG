using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Encounter : MonoBehaviour
{
    BattleObjectData enemyData;
    public SpwanManager spwanManager;    

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Monster")
        {
            
            gameObject.GetComponent<PlayerMove>().speed =0f;
            enemyData =other.gameObject.GetComponent<MonsterEncounter>().enemyObjectData ;
            spwanManager.SpawnDestroy();
            InfomationManager.instance.Notice(enemyData.name + "을(를) 만났다",1);
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>().SetBattleUnits(enemyData, gameObject.GetComponent<Player>());
        CameraManager.instance.OnBattle();
    }
}
