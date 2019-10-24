using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour

{
    private Camera cam;
    public float posX;
    public GameObject ground;
    private bool groundGameOver;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        posX = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        groundGameOver = ground.GetComponent<DeadCollider>().gameOver;
        if (groundGameOver == false)
        {
            posX++;
            // Debug.Log("here"+cam.transform.position.x);
            //cam.transform.position.Set(posX, cam.transform.position.y, cam.transform.position.z);
            //cam.GetComponent<Transform>().position();
            if (cam.transform.position.x > 67)
            {
                cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
            }
            else
            {
                cam.transform.position = cam.transform.position + new Vector3(.05f, 0, 0);
            }
        }
        else
        {
            Debug.Log("gameOver");
            Application.Quit();
        }
    }
}
