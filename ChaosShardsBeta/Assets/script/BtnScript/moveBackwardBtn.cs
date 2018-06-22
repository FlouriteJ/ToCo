﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveBackwardBtn : MonoBehaviour {

    //获取控制对象
    private GameObject playerSelf;
    private GameObject gameFunc;

    // Use this for initialization
    void Start()
    {
        playerSelf = GameObject.Find("self");
        gameFunc = GameObject.Find("GameManager");

        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        //Debug.Log("hello");
        //playerSelf.GetComponent<effect_self>().move(-1);
        if(gameFunc.GetComponent<gameManager>().can_backward())
        {
            gameFunc.GetComponent<gameManager>().backward();
        }

    }
}
