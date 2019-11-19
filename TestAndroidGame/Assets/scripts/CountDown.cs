using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{

 //   float timeLeft = 30f;
 //   public Text uiText;
 //   GameObject puzzle;
 //   GameManage gameManageObj;
 //  // private Text textTime;
 ////   public float mainTimer;
    //private bool canCount = true;

    //private void Start()
    //{
    //   // uiText = this.GetComponent<Text>();
    //    puzzle = GameObject.Find("puzzle_escape");
    //    gameManageObj = FindObjectOfType<GameManage>();

    //}

    //void FixedUpdate()
    //{
    //    if (timeLeft >0f && canCount)
    //    {
    //        timeLeft -= Time.deltaTime;
    //     //   Debug.Log("timeleft"+ timeLeft.ToString("f0") + 's');
    //        // timer = Time.deltaTime;
    //        //        Debug.Log("greaterthan0"+timer);
    //        uiText.text = timeLeft.ToString("f0") + 's';

    //       // GameOver(true);
    //       // canCount = false;

    //    } else 
    //    {
    //        if (puzzle.GetComponent<Puzzle>().CompletedPuzzle()) {
    //            GameOver(true);
    //        } else {
    //            GameOver(false);
    //            canCount = false;
    //        }
           
    //    }
    //}

    //void GameOver(bool flagWL) {
       
    //    if (!flagWL) {
    //        Debug.Log("GameOver() inside of flagwl is equal to false");
    //        gameManageObj.changeScene = true;
    //        gameManageObj.sceneNumber = 4;
    //        // SceneManager.LoadScene("LostScene", LoadSceneMode.Additive);

    //    }
      
    //    else {
    //        Debug.Log("GameOver() inside of flagwl is equal to true");
    //        // SceneManager.LoadScene("WinScene", LoadSceneMode.Additive);
    //        gameManageObj.changeScene = true;
    //        gameManageObj.sceneNumber = 3;
    //    }
    //  //  GameObject.Find("Canvas_escape").SetActive(false);

    //}
}
