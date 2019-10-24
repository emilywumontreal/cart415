using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndriodJump : MonoBehaviour
{
    public bool grounded = true;
    public float jumpPower = 1;
    public Rigidbody2D rigidCat;
    public float micAveragePower;
    public float threadshold = 25;
  
    // Start is called before the first frame update
    void Start()
    {
        rigidCat = this.GetComponent<Rigidbody2D>();
     //   Debug.Log(rigidCat);

 
}

// Update is called once per frame
void FixedUpdate()
    {
        micAveragePower = this.GetComponent<MicControl>().average*1000;
      //  Debug.Log("micpower==="+micAveragePower);
        //rigidCat.GetComponent<Rigidbody2D>().velocity.Set(rigidCat.GetComponent<Rigidbody2D>().velocity.x, 200);
       // if ((grounded==true))

           // Debug.Log("on ground"); 
            rigidCat.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, micAveragePower), ForceMode2D.Impulse);
            grounded = false;

       
        }
    }


