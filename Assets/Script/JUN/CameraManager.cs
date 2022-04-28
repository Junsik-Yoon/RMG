using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private static CameraManager _instance;

    public static CameraManager instance
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
  public Camera maincamera;
  public Camera battlecamera;

private void Start() {
    maincamera.enabled = true;
    battlecamera.enabled = false;
}
  public void OnBattle()
  {
   maincamera.enabled = false;
   battlecamera.enabled = true;
  }

  public void EndBattle()
  {
    maincamera.enabled = true;
    battlecamera.enabled = false;
  }
  public void ShakeCamera()
  {
    StartCoroutine(Shake());
     
  }
  private void ResetCamera()
  {
    battlecamera.transform.position = new Vector3(43.53f,2f,-10f);
  }
  IEnumerator Shake()
  {
    for(int i=0; i<10; ++i)
    {
      battlecamera.transform.position = new Vector3(44f,2.5f,-10f);
      yield return new WaitForSeconds(0.1f);
      battlecamera.transform.position = new Vector3(43f,1.5f,-10f);
      yield return new WaitForSeconds(0.1f);
    }
    ResetCamera(); 
  }
}
