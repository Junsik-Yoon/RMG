using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
   public GameObject obj;
    float randomX; //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
    float randomY; 

    List<GameObject> spawnPoints;

        private void Start() {
            
            spawnPoints = new List<GameObject>();
            Spawn();
        }
        
        void Spawn()
        {
             randomX = Random.Range(8f, 14f); 
            randomY = Random.Range(26f, 30f); 
            GameObject encounter = Instantiate(obj, new Vector3(randomX, randomY, 0f), Quaternion.identity);  
            randomX = Random.Range(8f, 14f); 
            randomY = Random.Range(26f, 30f); 
            GameObject encounter1 = Instantiate(obj, new Vector3(randomX, randomY, 0f), Quaternion.identity);  
           randomX = Random.Range(8f, 14f); 
            randomY = Random.Range(26f, 30f); 
            GameObject encounter2 = Instantiate(obj, new Vector3(randomX, randomY, 0f), Quaternion.identity);  
            randomX = Random.Range(8f, 14f); 
            randomY = Random.Range(26f, 30f); 
            GameObject encounter3 = Instantiate(obj, new Vector3(randomX, randomY, 0f), Quaternion.identity); 
            
            
            spawnPoints.Add(encounter);
            spawnPoints.Add(encounter1);
            spawnPoints.Add(encounter2);
            spawnPoints.Add(encounter3);
            this.enabled = false;
        }
        void SpawnDestroy()
        {
            for(int i=0; i<spawnPoints.Count;++i)
            {
                Destroy(spawnPoints[i]);
            }
                  
        }


}
