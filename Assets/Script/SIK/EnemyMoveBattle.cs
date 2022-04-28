using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBattle : MonoBehaviour
{
    public GameObject fireball;
    public GameObject arrow;

    public GameObject smoke;

    public GameObject dog;
    public bool isTurn;
    public float moveSpeed = 5f;
    Vector2 prevPos;
    Vector2 dir;
    bool isMoving=false;
    private void FixedUpdate()
    {
        if(isMoving)
        {            
            transform.Translate(dir*moveSpeed*Time.deltaTime);
        }
    }
    public void Approach(Vector2 _dir)
    {
        Debug.Log(gameObject.name);
        if(gameObject.name == "Dracula(Clone)")
        {
            prevPos = transform.position;
            dir = _dir;
            isMoving=true;
        }
        else if(gameObject.name == "Druid(Clone)")
        {
            Instantiate(dog,transform.position,Quaternion.identity).GetComponent<Dog>().SetDir(_dir);
        }
        else if(gameObject.name == "Archer(Clone)")
        {
            Instantiate(arrow,transform.position,Quaternion.identity).GetComponent<Arrow>().SetDir(_dir);
        }
        else if(gameObject.name == "HorseKnight(Clone)")
        {
            prevPos = transform.position;
            dir = _dir;
            isMoving=true;
        }
        else if(gameObject.name == "Magician(Clone)")
        {
            Instantiate(fireball,transform.position,Quaternion.identity).GetComponent<Fireball>().SetDir(_dir);
            
        }
        else if(gameObject.name == "OgreMan(Clone)")
        {
            prevPos = transform.position;
            StartCoroutine(Crash());
        }
        else if(gameObject.name == "GoodGun(Clone)")
        {
            prevPos = transform.position;
            dir = _dir;
            isMoving=true;
        }


        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if((other.gameObject.tag=="Player"||other.gameObject.tag=="Companion") && isTurn)
        {
            dir = (prevPos - (Vector2)transform.position).normalized;
            StartCoroutine(StopMoving());
        }
    }
    IEnumerator StopMoving()
    {
        yield return new WaitForSeconds(0.2f);
        isMoving = false;
        transform.position = prevPos;
        GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>().isBattlePaused = false;
        isTurn=false;
    }
    IEnumerator Crash()
    {
        isMoving=true;
        dir = new Vector2(1,0);
        yield return new WaitForSeconds(0.7f);
        dir = new Vector2(0,1);
        moveSpeed = 30f;
        yield return new WaitForSeconds(0.2f);
        dir = new Vector2(0,-1);
        yield return new WaitForSeconds(0.2f);
        moveSpeed = 5f;
        CameraManager.instance.ShakeCamera();
        Instantiate(smoke,transform.position,Quaternion.identity);
        dir = (prevPos - (Vector2)transform.position).normalized;
        StartCoroutine(StopMoving());

    }
}
