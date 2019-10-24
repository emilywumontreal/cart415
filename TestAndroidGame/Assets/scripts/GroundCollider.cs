using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour

{
    public bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // called when the cat hits the ground
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name.Equals("blackcat"))
        {
            Debug.Log("OnCollisionEnter2D" + col.gameObject.name);

            isGround = true;
            //Application.Quit();
        }
    }


}
