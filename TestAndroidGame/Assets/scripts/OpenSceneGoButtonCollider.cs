using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneGoButtonCollider : MonoBehaviour
{
  //  public bool isOpenScene;
  //  public int checkpoint;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
       // isOpenScene = true;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // called when the cat hits the ground
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("openscenebuttoncollide");

        if (col.gameObject.name.Equals("blackcat"))
        {

            Debug.Log("gameover is false--checkpoint starts");
            if (PlayerPrefs.GetInt("checkpoint", 0) == 0)
            {
                Debug.Log("checkpiont=0 in cameramove script");
                cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);

                // SceneManager.LoadScene("WinScene");
            }
            else if (PlayerPrefs.GetInt("checkpoint", 0) == 1)
            {
                cam.transform.position = new Vector3(103, cam.transform.position.y, cam.transform.position.z);
                // SceneManager.LoadScene("LostScene");
                //  Debug.Log("gameOver");
                // Application.Quit();
            }
            else if (PlayerPrefs.GetInt("checkpoint", 0) == 2)
            {
                Debug.Log("checkpoint2_setup");

                cam.transform.position = new Vector3(209, cam.transform.position.y, cam.transform.position.z);
            }
            else if (PlayerPrefs.GetInt("checkpoint", 0) == 3)
            {
                PlayerPrefs.SetInt("checkpoint", 0);

                // SceneManager.LoadScene("WinScene");
            }

            //  Debug.Log("OnCollisionEnter2D" + col.gameObject.name);

            //isOpenScene = false;
            // Application.LoadLevel("testingscene2");
            SceneManager.LoadScene("KittyBuddyGo");
            //Application.Quit();
        }


    }


}
