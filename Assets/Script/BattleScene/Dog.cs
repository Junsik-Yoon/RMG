using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
   Vector2 direction;

    Animator anim;
    bool isMove=false;
    public float moveSpeed = 5f;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void SetDir(Vector2 dir)
    {
        direction = dir;
        isMove = true;
    }
    private void FixedUpdate()
    {
        if(isMove)
        {
            transform.Translate(direction*moveSpeed*Time.fixedDeltaTime);
        }
        
    }
    public void Attack()
    {
        moveSpeed=0f;
        anim.SetTrigger("isAttack");
    }
    public void DestroySelf()
    {
        GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>().isBattlePaused = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"|| other.gameObject.tag == "Companion")
        {
            Attack();
        }
    }
}
