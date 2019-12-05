using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour

{
    private Camera cam;
    public float posX;
    public GameObject gameManager;
   // private bool groundGameOver;

    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log("test");
        cam = Camera.main;
        posX = 0;

        if (PlayerPrefs.GetInt("checkpoint", 0) == 0)
        {
          //  Debug.Log("checkpiont=0 in cameramove script");
            cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);

            // SceneManager.LoadScene("WinScene");
        }
        else if (PlayerPrefs.GetInt("checkpoint", 0) == 1)
        {
            cam.transform.position = new Vector3(113, cam.transform.position.y, cam.transform.position.z);
            // SceneManager.LoadScene("LostScene");
            //  Debug.Log("gameOver");
            // Application.Quit();
        }
        else if (PlayerPrefs.GetInt("checkpoint", 0) == 2)
        {
           // Debug.Log("checkpoint2_setup");

            cam.transform.position = new Vector3(209, cam.transform.position.y, cam.transform.position.z);
        }
        else if (PlayerPrefs.GetInt("checkpoint", 0) == 3)
        {
            PlayerPrefs.SetInt("checkpoint", 0);

            SceneManager.LoadScene("WinScene");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // groundGameOver = ground.GetComponent<DeadCollider>().gameOver;
        if (gameManager.GetComponent<GameManage>().gameOver == false)
        {
            posX++;
            cam.transform.position = cam.transform.position + new Vector3(.05f, 0, 0);
            // Debug.Log("here"+cam.transform.position.x);
            // cam.transform.position.Set(posX, cam.transform.position.y, cam.transform.position.z);
            //cam.GetComponent<Transform>().position();
            //  if (cam.transform.position.x > 275)
            //  {
            //cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
            //  }
            //else
            //{
        /*    Debug.Log("gameover is false--checkpoint starts");
            if (PlayerPrefs.GetInt("checkpoint", 0) == 0)
            {
                Debug.Log("checkpiont=0 in cameramove script");
                cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
                
                // SceneManager.LoadScene("WinScene");
            }
            else if (PlayerPrefs.GetInt("checkpoint", 0) == 1)
            {
                cam.transform.position = new Vector3(103, 0, 0) + new Vector3(.05f, 0, 0);
                // SceneManager.LoadScene("LostScene");
                //  Debug.Log("gameOver");
                // Application.Quit();
            }
            else if (PlayerPrefs.GetInt("checkpoint",0) == 2)
            {
                cam.transform.position = new Vector3(209, 0, 0) + new Vector3(.05f, 0, 0);
            }
            else if (PlayerPrefs.GetInt("checkpoint", 0) == 3)
            {
                PlayerPrefs.SetInt("checkpoint", 0);
               
                // SceneManager.LoadScene("WinScene");
            }*/

        }
        //}
        //else
        //{
        //    if (PlayerPrefs.GetInt("checkpoint",10) == 3) 
        //    {
        //        SceneManager.LoadScene("WinScene");
        //     }
        //    else
        //     { 
        //        SceneManager.LoadScene("LostScene");
        //    //  Debug.Log("gameOver");
        //       // Application.Quit();
        //    }
        //}
    }
}
