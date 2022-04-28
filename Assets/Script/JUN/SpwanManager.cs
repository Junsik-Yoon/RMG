using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    
    private static SpwanManager _instance;

    public static SpwanManager instance
    {
        get
        {
            return _instance;
        }
    }
    private void Awake()
    {   
        DontDestroyOnLoad(gameObject);
        _instance = this;
    }
    public GameObject encounter;
    public GameObject encounter2;
    int randomX; //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
    int randomY; 

    List<GameObject> spawnPoints;

        private void Start() 
        {
            
            spawnPoints = new List<GameObject>();
            Spawn();
        }
        
        public void Spawn()
        {
            StartCoroutine(SpawnWait());

            
        }
        public void SpawnDestroy()
        {
            for(int i=0; i<spawnPoints.Count;++i)
            {
                Destroy(spawnPoints[i]);
            }
                  
        }

        IEnumerator SpawnWait()
        {
            yield return new WaitForSeconds(3.0f);
            for(int i=27; i<31; ++i)
            {   
                randomX = Random.Range(9, 14); 
                randomY = i;
                Vector2 randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounter, randomVector , Quaternion.identity));
                randomX = Random.Range(-4, 1); 
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounter2, randomVector , Quaternion.identity));
            }
        }
}
