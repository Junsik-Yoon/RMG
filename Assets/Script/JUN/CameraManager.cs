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
}
