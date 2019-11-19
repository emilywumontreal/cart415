/*
 * this code is from https://answers.unity.com/questions/524064/easy-way-to-generate-8-piece-sliding-puzzle-so-tha.html
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializePuzzle : MonoBehaviour
{
    private Sprite changeSprite;
    private void Start()
    {
       
        Generate(3);
    }

    void Update()
    {
      //  
    }

  //  generate Solvable Puzzle() 
    
        public int[] puzzle = { 0, 1, 2, 3, 4, 5, 6 ,7,-1 };
        private int[,] connections = { { 1, 3, -1, -1 }, { 0, 2, 4, -1 }, { 1, 5, -1, -1 },
                                   { 0, 4, 6, -1 }, { 1, 3, 5, 7 }, { 2, 4, 8, -1 },
                                   { 3, 7, -1, -1 }, { 4, 6, 8, -1 }, { 5, 7, -1, -1 } };


    public void Generate(int iterations)
    {
        for (int a = 0; a < iterations; a++)
        {
            Next();
           // Debug.Log("a===:::" + a);
           // Debug.Log("puzzle_length====:::"+puzzle.Length);
            for (int x = 0; x < puzzle.Length; x++)
            {
             //  Debug.Log(x + "===" + puzzle[x]);

            }
        }

    }

    private void Next()
    {
        var puzzlePieces = FindObjectsOfType<PuzzlePiece>();
        for (int x = 0; x < puzzle.Length; x++)
        {
            //Debug.Log("x===:outside of if condition:" + x);
            //Debug.Log("puzle[x]===:::"+puzzle[x]);
            if (puzzle[x] == -1)
            {
                List<int> possibleConnections = new List<int>();

                for (int m = 0; m < 4; m++)
                {
                   
                    if (connections[x, m] != -1)
                   
                    {
                      //  Debug.Log("connectionsd_data"+connections[x, m]);
                        possibleConnections.Add(connections[x, m]);
                    }
                }

                // print random arry numbers:
               
             //   foreach (int puzzleConnection in possibleConnections ) { print("puzzleconnections=====:::"+possibleConnections[puzzleConnection]); }

                int target = RandomValueFromArray(possibleConnections.ToArray());
             //   Debug.Log("puzle[target]===:::" + puzzle[target]);
                int targetValue = puzzle[target];
               // Debug.Log("targetValue-::::"+targetValue);
              //  Debug.Log("puzzle[x]====::::" + puzzle[x]);
                puzzle[target] = puzzle[x];
                puzzle[x] = targetValue;

            //    Debug.Log("Image" + target);
              //  Debug.Log("Image" + targetValue);
                GameObject emptyTest = GameObject.Find("Image" + target);
                GameObject otherTest = GameObject.Find("Image" + x);
                ChangeImageSprites(emptyTest.GetComponent<Image>(), otherTest.GetComponent<Image>());

                return;
            }
        }
    }

    private T RandomValueFromArray<T>(T[] array)
    {
        int random = Random.Range(0, array.Length);
       // Debug.Log("ramdomarray==" + array[random]);
        return array[random];
    }

    void ChangeImageSprites(Image firstSprite, Image secondSprite)
    {

        Sprite temp = firstSprite.sprite;
        //    Debug.Log("source:: " + temp);
        //    Debug.Log("dest:: " + secondSprite);
        firstSprite.sprite = secondSprite.sprite;
        secondSprite.sprite = temp;
      
    }
}



