﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadCollider : MonoBehaviour
{
    // public static bool gameOver;
    public GameObject gameManager;
    // Start is called before the first frame update
    public int checkpoint = 0;
    void Start()
    {
      //  gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(this.gameObject.name);

    }

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
       // Debug.Log("collision");
        if (col.gameObject.name.Equals("blackcat"))
        {
            //  Debug.Log("OnCollisionEnter2D" + col.gameObject.name);
            //  Debug.Log("OnCollisionEnter2D tHIS" + this.gameObject.name);


            //play cat screem voice
            SceneManager.LoadScene("LostScene");
            

            //  gameManager.GetComponent<GameManage>().gameOver = true;
            //   Application.Quit();



        }
    }


}
