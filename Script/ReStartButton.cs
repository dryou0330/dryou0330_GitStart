﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReStartButton : MonoBehaviour
{
    public string sceneName = "MainStage"; // 다음씬으로 이동할 이름 

    public void ClickStart()
    {
        Debug.Log("게임 스타트 로딩중 ..");
        SceneManager.LoadScene(sceneName);
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameManager.canPlayerMove = false;
        
    }


}
