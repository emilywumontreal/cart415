using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCollider : MonoBehaviour
{
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
       
        if (col.gameObject.name.Equals("blackcat"))
        {
            Debug.Log("OnCollisionEnter2D" + col.gameObject.name);
            gameOver = true;
            Application.Quit();
        }
    }


}
