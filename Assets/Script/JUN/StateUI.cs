using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateUI : MonoBehaviour
{
  public Text pName;
  public Text pHp;
  public Text pDamage;
  public Text pAgility;
  public Player player;
 
private void Awake() {
    player.GetComponent<Player>();
}
  private void Start() {
      pName.text    =  "이름 : " + player.playerName;
      pDamage.text  =  "공격력" + player.damage; 
      pAgility.text =  "공격속도" + player.defaultAgility;
  }
  private void FixedUpdate() {
    pHp.text      =  "체력" + player.curHP + "/" + player.maxHP;
  }
}