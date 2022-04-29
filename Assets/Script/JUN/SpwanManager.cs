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

    public GameObject enconterBOSS;
    public GameObject encounterDracula;
    public GameObject encounterHorse;

    public GameObject encounterDruid;
    public GameObject encounterOgre;
    public GameObject encounterArcher;
    public GameObject encounterMagician;
    
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
        public void SpawnBOSS()
        {
            
            spawnPoints.Add(Instantiate(enconterBOSS,new Vector3(5.2f,30,0),Quaternion.identity));     
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
            Vector2 randomVector;
            for(int i=27; i<31; ++i)
            {   
                randomX = Random.Range(9, 14); 
                randomY = i;
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterDracula, randomVector , Quaternion.identity));
                randomX = Random.Range(-4, 1); 
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterHorse, randomVector , Quaternion.identity));
            }
             for(int i=32; i<36; ++i)
             {
                randomX = Random.Range(9, 14); 
                randomY = i;
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterDruid, randomVector , Quaternion.identity));
                randomX = Random.Range(-4, 1); 
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterArcher, randomVector , Quaternion.identity));
             }

            for(int i=22; i<26; ++i)
            {
                randomX = Random.Range(9, 14); 
                randomY = i;
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterOgre, randomVector , Quaternion.identity));
                randomX = Random.Range(-4, 1); 
                randomVector = new Vector2(randomX,randomY);
                spawnPoints.Add(Instantiate(encounterMagician, randomVector , Quaternion.identity));
             }
        }
}
