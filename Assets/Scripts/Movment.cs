using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField]
    float stepSize = 20f;

    float leftWall = -400, rightWall = 1280, upperWall = 660, lowerWall = -280;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) // up
        // {
        //     transform.position += new Vector3(0, stepSize, 0);
        // }
        // else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) // down
        // {
        //     transform.position += new Vector3(0, -stepSize, 0);
        // }
        // else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) // left
        // {
        //     transform.position += new Vector3(-stepSize, 0, 0);
        // }
        // else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) // right
        // {
        //     transform.position += new Vector3(stepSize, 0, 0);
        // }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // up
        {
            if(transform.position.y < upperWall){
                transform.position += new Vector3(0, stepSize, 0);
            }
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) // down
        {
            if(transform.position.y > lowerWall){
                transform.position += new Vector3(0, -stepSize, 0);
            }
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // left
        {
            if(transform.position.x > leftWall){    
                transform.position += new Vector3(-stepSize, 0, 0);
            }
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // right
        {
            if(transform.position.x < rightWall){
                transform.position += new Vector3(stepSize, 0, 0);
            }
        }
    }
}
