using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    /* Start is called before the first frame update
    public bool changeScene  = false;
    Scene p_Scene;
   public int sceneNumber;*/
    public bool gameOver;
    public int checkpoint;
    void Start()
    {
       // DontDestroyOnLoad(this.gameObject);
        gameOver = false;
        checkpoint = PlayerPrefs.GetInt("checkpoint", 10);
        Debug.Log("checkpoint==="+checkpoint);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (changeScene == true &&sceneNumber==1)
        {
          //  GameObject.Find("Canvas_open").SetActive(false);
            p_Scene = SceneManager.GetActiveScene();
            string sceneName = p_Scene.name;
            Debug.Log(sceneName);
            SceneManager.LoadSceneAsync("Escape", LoadSceneMode.Single);
            changeScene = false;
        }
        else if (changeScene == true && sceneNumber == 2)
        {
          //  Debug.Log("escape_rightarrow_click");
            p_Scene = SceneManager.GetActiveScene();
            string sceneName = p_Scene.name;
          //  Debug.Log(sceneName);
            SceneManager.LoadScene("EscapeLevel2", LoadSceneMode.Single);
          //  GameObject.Find("Canvas_escape").SetActive(false);
          //  GameObject.Find("Canvas_escapelevel2").SetActive(true);
            changeScene = false;
        } else if (changeScene == true && sceneNumber == 3) {
            p_Scene = SceneManager.GetActiveScene();
            string sceneName = p_Scene.name;
            Debug.Log(sceneName);
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
            //  GameObject.Find("Canvas_escape").SetActive(false);
            //  GameObject.Find("Canvas_escapelevel2").SetActive(true);
            changeScene = false;
        } else if (changeScene == true && sceneNumber == 4) {
           // Debug.Log("getting into scenenumber 4");
            p_Scene = SceneManager.GetActiveScene();
            string sceneName = p_Scene.name;
            Debug.Log(sceneName);
            SceneManager.LoadScene("LostScene", LoadSceneMode.Single);
            //  GameObject.Find("Canvas_escape").SetActive(false);
            //  GameObject.Find("Canvas_escapelevel2").SetActive(true);
            changeScene = false;
        } else if (changeScene == true && sceneNumber == 0)
        {
            p_Scene = SceneManager.GetActiveScene();
            string sceneName = p_Scene.name;
           // Debug.Log(sceneName);
            SceneManager.LoadScene("OpenScene", LoadSceneMode.Single);
            //  GameObject.Find("Canvas_escape").SetActive(false);
            //  GameObject.Find("Canvas_escapelevel2").SetActive(true);
            changeScene = false;
        }*/
    }
}
