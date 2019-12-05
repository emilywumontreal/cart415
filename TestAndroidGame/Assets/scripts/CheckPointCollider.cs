using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointCollider : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("checkpoint1"))
        {
            //  Debug.Log("OnCollisionEnter2D" + col.gameObject.name);
            PlayerPrefs.SetInt("checkpoint", 1);
            //gameManager.GetComponent<GameManage>().checkpoint = 1;
            Debug.Log("checkpoint===1");

           // Debug.Log("position=="+Camera.transform.position);
            //Application.Quit();
        }
        if (col.gameObject.name.Equals("checkpoint2"))
        {
            //  Debug.Log("OnCollisionEnter2D" + col.gameObject.name);

            PlayerPrefs.SetInt("checkpoint", 2);
            Debug.Log("checkpoint===2");
            //Application.Quit();
        }
        if (col.gameObject.name.Equals("checkpoint3"))
        {
            //  Debug.Log("OnCollisionEnter2D" + col.gameObject.name);

            PlayerPrefs.SetInt("checkpoint", 3);
            SceneManager.LoadScene("WinScene");
           // Debug.Log("checkpoint==="+ PlayerPrefs.GetInt("checkpoint"));
            //Application.Quit();
        }
        Debug.Log("checkpoint===" + PlayerPrefs.GetInt("checkpoint"));

    }
}